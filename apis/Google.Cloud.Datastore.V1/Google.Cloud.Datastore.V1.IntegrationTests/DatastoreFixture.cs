// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using Google.Api.Gax;
using Google.Api.Gax.ResourceNames;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Http;
using Google.Cloud.ClientTesting;
using Google.Cloud.Firestore.Admin.V1;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Firestore.Admin.V1.Database.Types;

namespace Google.Cloud.Datastore.V1.IntegrationTests
{
    /// <summary>
    /// Fixture which is set up at the start of the test run, and torn down at the end.
    /// All entities use the same partition, which is then wiped at the end of the run.
    /// </summary>
    [CollectionDefinition(nameof(DatastoreFixture))]
    public sealed class DatastoreFixture : CloudProjectFixtureBase, ICollectionFixture<DatastoreFixture>
    {
        private const int RetryCount = 10;
        private static readonly TimeSpan RetryDelay = TimeSpan.FromSeconds(3);

        private readonly FirestoreAdminClient _firestoreAdminClient;

        internal bool RunningOnEmulator { get; }

        // Creating databases and indexes can take a while.
        // We don't want to wait *forever* (which would be the behavior of default poll settings)
        // but we need to have a timeout of more than a minute.
        private static readonly PollSettings AdminOperationPollSettings =
            new PollSettings(expiration: Expiration.FromTimeout(TimeSpan.FromMinutes(5)), delay: TimeSpan.FromSeconds(5));

        public string NamespaceId { get; }
        public PartitionId PartitionId => new PartitionId { ProjectId = ProjectId, NamespaceId = NamespaceId };

        public DatastoreFixture()
        {
            NamespaceId = IdGenerator.FromDateTime(prefix: "test-");
            RunningOnEmulator = !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("DATASTORE_EMULATOR_HOST"));
            _firestoreAdminClient = FirestoreAdminClient.Create();
        }

        public override void Dispose()
        {
            var client = DatastoreClient.Create();
            // Delete all the entities in our partition.
            // TODO: Transactions? Paging?
            var query = new Query { Projection = { DatastoreConstants.KeyProperty } };
            var response = client.RunQuery(new RunQueryRequest { ProjectId = ProjectId, PartitionId = PartitionId, Query = query });
            var deletions = response.Batch.EntityResults.Select(entityResult => entityResult.Entity.ToDelete());
            client.Commit(ProjectId, CommitRequest.Types.Mode.NonTransactional, deletions);
        }

        // Helper methods to retry query operations. Global queries are eventually consistent, so we retry queries for a short while.
        // (Most of the time the results are valid immediately anyway, in practice.)
        public void RetryQuery(Action check)
        {
            int attempt = 0;
            while (true)
            {
                try
                {
                    check();
                    return;
                }
                catch (Exception) when (attempt < RetryCount)
                {
                    attempt++;
                    Thread.Sleep(RetryDelay);
                }
            }
        }

        public async Task RetryQueryAsync(Func<Task> check)
        {
            int attempt = 0;
            while (true)
            {
                try
                {
                    await check().ConfigureAwait(false);
                    return;
                }
                catch (Exception) when (attempt < RetryCount)
                {
                    attempt++;
                    await Task.Delay(RetryDelay);
                }
            }
        }

        public DatastoreDb CreateDatastoreDb(string namespaceId = null)
        {
            string effectiveNamespace = namespaceId ?? NamespaceId;
            var builder = new DatastoreDbBuilder
            {
                ProjectId = ProjectId,
                NamespaceId = effectiveNamespace,
                EmulatorDetection = EmulatorDetection.EmulatorOrProduction
            };
            return builder.Build();
        }

        public DatastoreDb CreateDatastoreDbWithDatabase(string databaseId)
        {
            var builder = new DatastoreDbBuilder
            {
                ProjectId = ProjectId,
                NamespaceId = NamespaceId,
                DatabaseId = databaseId ?? "",
                EmulatorDetection = EmulatorDetection.EmulatorOrProduction
            };
            return builder.Build();
        }

        public async Task RunWithTemporaryDatabaseAsync(Action<string> testFunction)
        {
            var databaseId = IdGenerator.FromDateTime(prefix: "test-db-");
            await CreateDatabaseAsync(databaseId);

            try
            {
                testFunction(databaseId);
            }
            finally
            {
                // Cleanup the test database.
                try
                {
                    await DeleteDatabaseAsync(databaseId);
                }
                catch (Exception)
                {
                    // Silently ignore errors to prevent tests from failing.
                }
            }
        }

        /// <summary>
        /// Creates a new Datastore database using Firestore Admin Client.
        /// </summary>
        public async Task CreateDatabaseAsync(string databaseId)
        {
            var pr = new ProjectName(ProjectId);
            // Creating a new database is not supported on Datastore emulator.
            Assert.False(RunningOnEmulator);
            var operation = await _firestoreAdminClient.CreateDatabaseAsync(
                new ProjectName(ProjectId),
                new Database { LocationId = "us-east1", Type = DatabaseType.DatastoreMode },
                databaseId);
            await operation.PollUntilCompletedAsync(AdminOperationPollSettings);
            Console.WriteLine($"Success creating database {databaseId}");
        }

        private async Task DeleteDatabaseAsync(string databaseId)
        {
            try
            {
                await _firestoreAdminClient.DeleteDatabaseAsync(new DatabaseName(ProjectId, databaseId));
            }
            catch (Exception)
            {
                // Silently ignore errors to prevent tests from failing.
            }
        }
    }
}
