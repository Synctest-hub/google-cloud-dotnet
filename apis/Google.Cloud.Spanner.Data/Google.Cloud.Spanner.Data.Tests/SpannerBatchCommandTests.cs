// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Cloud.Spanner.V1.Tests;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    // Note: SpannerConnection cannot be mocked because it's a sealed
    // class so there are limits to what can be tested here.
    public class SpannerBatchCommandTests
    {
        [Fact]
        public void ConnectionConstructor()
        {
            var connection = new SpannerConnection();
            var command = new SpannerBatchCommand(connection);

            Assert.Empty(command.Commands);
            Assert.Same(connection, command.Connection);
            Assert.Null(command.Transaction);
            Assert.Equal(SpannerBatchCommandType.None, command.CommandType);
        }

        [Fact]
        public void TransactionConstructor()
        {
            var connection = new SpannerConnection();
            var pool = new FakeSessionPool();
            var session = PooledSession.FromSessionName(pool, new SessionName("project", "instance", "database", "session"));

            var transaction = new SpannerTransaction(connection, TransactionMode.ReadWrite, session: session, timestampBound: null, isRetriable: false);
            var command = new SpannerBatchCommand(transaction);

            Assert.Empty(command.Commands);
            Assert.Same(connection, command.Connection);
            Assert.Same(transaction, command.Transaction);
            Assert.Equal(SpannerBatchCommandType.None, command.CommandType);
        }

        public static IEnumerable<object[]> ValidCommands
        {
            get
            {
                yield return new object[]
                {
                    (Action<SpannerBatchCommand>)(command =>
                    command.Add(
                        "DELETE FROM myTable WHERE Key=@key",
                        new SpannerParameterCollection { { "key", SpannerDbType.Int64, 5} })),
                    "DELETE FROM myTable WHERE Key=@key",
                    1
                };
                yield return new object[]
                {
                    (Action<SpannerBatchCommand>)(command =>
                    command.Add(
                        new SpannerCommand { CommandText = "UPDATE myTable SET Value = 5 WHERE Key = 1" })),
                    "UPDATE myTable SET Value = 5 WHERE Key = 1",
                    0
                };
                yield return new object[]
                {
                    (Action<SpannerBatchCommand>)(command =>
                    command.Add(
                        SpannerCommandTextBuilder.CreateDmlTextBuilder("INSERT INTO myTable (Key, Value) SELECT Key, Value + 1 FROM myTable WHERE KEY = @Key"),
                        new SpannerParameterCollection { { "key", SpannerDbType.Int64, 3} })),
                    "INSERT INTO myTable (Key, Value) SELECT Key, Value + 1 FROM myTable WHERE KEY = @Key",
                    1
                };
            }
        }

        [Theory]
        [MemberData(nameof(ValidCommands))]
        public void AddValidCommands(Action<SpannerBatchCommand> addCommandAction, string expectedCommandText, int expectedParametersCount)
        {
            var connection = new SpannerConnection();
            var command = new SpannerBatchCommand(connection);

            addCommandAction(command);

            Assert.Equal(1, command.Commands.Count);
            Assert.Equal(expectedCommandText, command.Commands[0].CommandText, ignoreCase: true);

            Assert.Equal(expectedParametersCount, command.Commands[0].Parameters.Count);

            Assert.Same(connection, command.Connection);
            Assert.Null(command.Transaction);
            Assert.Equal(SpannerBatchCommandType.BatchDml, command.CommandType);
        }

        [Fact]
        public void AddSeveralCommands()
        {
            var connection = new SpannerConnection();
            var command = new SpannerBatchCommand(connection);

            var expectedCommandsInOrder = new List<string>();
            foreach (var testCase in ValidCommands)
            {
                ((Action<SpannerBatchCommand>)testCase[0])(command);
                expectedCommandsInOrder.Add((string)testCase[1]);
            }

            Assert.Equal(expectedCommandsInOrder, command.Commands.Select(c => c.CommandText), StringComparer.OrdinalIgnoreCase);

            Assert.Same(connection, command.Connection);
            Assert.Null(command.Transaction);
            Assert.Equal(SpannerBatchCommandType.BatchDml, command.CommandType);
        }

        [Fact]
        public void AddNonDmlCommand_FromEmpty()
        {
            var connection = new SpannerConnection();
            var command = new SpannerBatchCommand(connection);
            Assert.Throws<InvalidOperationException>(() => command.Add("drop database myDatabase"));
        }

        [Fact]
        public void AddNonDmlCommand_FromValid()
        {
            var connection = new SpannerConnection();
            var command = new SpannerBatchCommand(connection);

            command.Add(
                "DELETE FROM myTable WHERE Key=@key",
                new SpannerParameterCollection { { "key", SpannerDbType.Int64, 5 } });

            Assert.Throws<InvalidOperationException>(() => command.Add("drop database myDatabase"));
        }

        [Fact]
        public void CommandPriorityDefaultsToUnspecified()
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync();
            SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction();
            var command = transaction.CreateBatchDmlCommand();
            Assert.Equal(Priority.Unspecified, command.Priority);
        }

        [Fact]
        public void CommandIncludesPriority()
        {
            var priority = Priority.High;
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteBatchDmlAsync()
                .SetupCommitAsync();
            SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction();

            var command = transaction.CreateBatchDmlCommand();
            command.Add("UPDATE FOO SET BAR=1 WHERE TRUE");
            command.Priority = priority;
            command.ExecuteNonQuery();
            transaction.Commit();

            spannerClientMock.Received(1).ExecuteBatchDmlAsync(
                Arg.Is<ExecuteBatchDmlRequest>(request => request.RequestOptions.Priority == PriorityConverter.ToProto(priority)),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public void EphemeralTransactionIncludesPriorityOnBatchDmlAndCommit()
        {
            var priority = Priority.Medium;
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteBatchDmlAsync()
                .SetupCommitAsync();
            SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);

            var command = connection.CreateBatchDmlCommand();
            command.Add("UPDATE FOO SET BAR=1 WHERE TRUE");
            command.Priority = priority;
            command.ExecuteNonQuery();

            spannerClientMock.Received(1).ExecuteBatchDmlAsync(
                Arg.Is<ExecuteBatchDmlRequest>(request => request.RequestOptions.Priority == PriorityConverter.ToProto(priority)),
                Arg.Any<CallSettings>());
            spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.RequestOptions.Priority == PriorityConverter.ToProto(priority)),
                Arg.Any<CallSettings>());
        }

        public static TheoryData<TimeSpan?> ValidCommitDelayValues => SpannerTransactionTests.ValidCommitDelayValues;

        public static TheoryData<TimeSpan?> InvalidCommitDelayValues => SpannerTransactionTests.InvalidCommitDelayValues;

        [Fact]
        public void CommitDelay_DefaultsToNull()
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock.SetupBatchCreateSessionsAsync();
            SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);
            var command = connection.CreateBatchDmlCommand();

            Assert.Null(command.CommitDelay);
        }

        [Theory, MemberData(nameof(ValidCommitDelayValues))]
        public void CommitDelay_Valid(TimeSpan? value)
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock.SetupBatchCreateSessionsAsync();
            SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);
            var command = connection.CreateBatchDmlCommand();

            command.CommitDelay = value;

            Assert.Equal(value, command.CommitDelay);
        }

        [Theory, MemberData(nameof(InvalidCommitDelayValues))]
        public void CommitDelay_Invalid(TimeSpan? value)
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock.SetupBatchCreateSessionsAsync();
            SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);
            var command = connection.CreateBatchDmlCommand();

            Assert.Throws<ArgumentOutOfRangeException>(() => command.CommitDelay = value);
        }

        [Fact]
        public void CommitDelay_DefaultsToNull_ImplicitTransaction()
        {
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupExecuteBatchDmlAsync()
                .SetupCommitAsync();
            SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);

            var command = connection.CreateBatchDmlCommand();
            command.Add("UPDATE FOO SET BAR=1 WHERE TRUE");
            command.ExecuteNonQuery();

            spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.MaxCommitDelay == null),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public void CommitDelay_Propagates_ImplicitTransaction()
        {
            var commitDelay = TimeSpan.FromMilliseconds(100);

            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupExecuteBatchDmlAsync()
                .SetupCommitAsync();
            SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);

            var command = connection.CreateBatchDmlCommand();
            command.Add("UPDATE FOO SET BAR=1 WHERE TRUE");
            command.CommitDelay = commitDelay;
            command.ExecuteNonQuery();

            spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.MaxCommitDelay.Equals(Duration.FromTimeSpan(commitDelay))),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public void CommitDelay_SetOnCommand_SetOnExplicitTransaction_CommandIgnored()
        {
            var transactionCommitDelay = TimeSpan.FromMilliseconds(100);
            var commandCommitDelay = TimeSpan.FromMilliseconds(300);

            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupExecuteBatchDmlAsync()
                .SetupCommitAsync();
            SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction();
            transaction.CommitDelay = transactionCommitDelay;

            var command = transaction.CreateBatchDmlCommand();
            command.Add("UPDATE FOO SET BAR=1 WHERE TRUE");
            command.CommitDelay = commandCommitDelay;
            command.ExecuteNonQuery();

            transaction.Commit();

            spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.MaxCommitDelay.Equals(Duration.FromTimeSpan(transactionCommitDelay))),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public void CommitDelay_SetOnCommand_UnsetOnExplicitTransaction_CommandIgnored()
        {
            var commandCommitDelay = TimeSpan.FromMilliseconds(300);

            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupBeginTransactionAsync()
                .SetupExecuteBatchDmlAsync()
                .SetupCommitAsync();
            SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction();

            var command = transaction.CreateBatchDmlCommand();
            command.Add("UPDATE FOO SET BAR=1 WHERE TRUE");
            command.CommitDelay = commandCommitDelay;
            command.ExecuteNonQuery();

            transaction.Commit();

            spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.MaxCommitDelay == null),
                Arg.Any<CallSettings>());
        }

        [Fact]
        public void CommandIncludesRequestAndTransactionTag()
        {
            var requestTag = "request-tag-1";
            var transactionTag = "transaction-tag-1";
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock
                .SetupBatchCreateSessionsAsync()
                .SetupExecuteBatchDmlAsync()
                .SetupCommitAsync();
            SpannerConnection connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock);
            SpannerTransaction transaction = connection.BeginTransaction();
            transaction.Tag = transactionTag;

            var command = transaction.CreateBatchDmlCommand();
            command.Add("UPDATE FOO SET BAR=1 WHERE TRUE");
            command.Tag = requestTag;
            command.ExecuteNonQuery();
            transaction.Commit();

            spannerClientMock.Received(1).ExecuteBatchDmlAsync(
                Arg.Is<ExecuteBatchDmlRequest>(request => request.RequestOptions.RequestTag == requestTag && request.RequestOptions.TransactionTag == transactionTag),
                Arg.Any<CallSettings>());
            spannerClientMock.Received(1).CommitAsync(
                Arg.Is<CommitRequest>(request => request.RequestOptions.RequestTag == "" && request.RequestOptions.TransactionTag == transactionTag),
                Arg.Any<CallSettings>());
        }

        private class FakeSessionPool : SessionPool.ISessionPool
        {
            public SpannerClient Client => throw new NotImplementedException();
            public IClock Clock => SystemClock.Instance;
            public SessionPoolOptions Options { get; } = new SessionPoolOptions();
            public void Release(PooledSession session, ByteString transactionId, bool deleteSession) =>  throw new NotImplementedException();
            public void Detach(PooledSession session) => throw new NotImplementedException();

            public Task<PooledSession> RefreshedOrNewAsync(PooledSession session, TransactionOptions transactionOptions, bool singleUseTransaction, CancellationToken cancellationToken) =>
                throw new NotImplementedException();
        }
    }
}
