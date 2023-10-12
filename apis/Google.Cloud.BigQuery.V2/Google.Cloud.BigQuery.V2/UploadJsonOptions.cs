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

using Google.Apis.Bigquery.v2.Data;
using System;
using System.Collections.Generic;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Options for <c>UploadJson</c> operations.
    /// </summary>
    public sealed class UploadJsonOptions : JobCreationOptions
    {
        /// <summary>
        /// Whether or not to accept rows with fields that are not specified in the schema,
        /// ignoring the extra fields.
        /// If not set, this is effectively false.
        /// </summary>
        public bool? AllowUnknownFields { get; set; }

        /// <summary>
        /// The maximum number of bad records that are ignored before the overall job fails.
        /// If not set, this is effectively 0.
        /// </summary>
        public int? MaxBadRecords { get; set; }

        /// <summary>
        /// Specifies whether the operation is allowed to create new tables.
        /// If not set, this is effectively <see cref="CreateDisposition.CreateIfNeeded"/>.
        /// </summary>
        public CreateDisposition? CreateDisposition { get; set; }

        /// <summary>
        /// Specifies the behavior if the destination table exists.
        /// If not set, this is effectively <see cref="WriteDisposition.WriteAppend"/>.
        /// </summary>
        public WriteDisposition? WriteDisposition { get; set; }

        /// <summary>
        /// Specifies whether or not the options (including schema) should automatically be inferred.
        /// If not set, this is effectively false.
        /// </summary>
        public bool? Autodetect { get; set; }

        /// <summary>
        /// The time partitioning to apply, if any. See <see cref="TimePartition"/> to create instances of <see cref="TimePartitioning"/>.
        /// </summary>
        public TimePartitioning TimePartitioning { get; set; }

        /// <summary>
        /// The encryption configuration to apply to the destination table, if any.
        /// </summary>
        public EncryptionConfiguration DestinationEncryptionConfiguration { get; set; }

        /// <summary>
        /// Allows the schema of the destination table to be updated as a side effect
        /// of the load job if a schema is autodetected or supplied in the job configuration.
        /// Schema update options are supported in two cases:
        /// when <see cref="WriteDisposition"/> is <see cref="WriteDisposition.WriteAppend"/>;
        /// when <see cref="WriteDisposition"/> is <see cref="WriteDisposition.WriteTruncate"/>
        /// and the destination table is a partition of a table, specified by partition decorators.
        /// <see cref="SchemaUpdateOption"/> is marked with the <see cref="System.FlagsAttribute"/>
        /// so several flags can be specified.
        /// </summary>
        public SchemaUpdateOption? DestinationSchemaUpdateOptions { get; set; }

        /// <summary>
        /// Optional action to perform after preparing the request. If this property is non-null,
        /// the <see cref="JobConfigurationLoad"/> used for a request will be passed to the delegate
        /// before the request is executed. This allows for fine-grained modifications which aren't
        /// otherwise directly supported by the properties in this options type.
        /// </summary>
        /// <remarks>
        /// Prefer the properties on this type over this modifier to prepare the request.
        /// Only use this modifier to configure aspects for which there are no properties available.
        /// This modifier is applied to the request after all properties on this type have been applied.
        /// The delegate is only called once per operation, even if the request is automatically retried.
        /// </remarks>
        public Action<JobConfigurationLoad> ConfigurationModifier { get; set; }

        internal void ModifyConfiguration(JobConfigurationLoad loadRequest)
        {
            if (AllowUnknownFields != null)
            {
                loadRequest.IgnoreUnknownValues = AllowUnknownFields;
            }
            if (MaxBadRecords != null)
            {
                loadRequest.MaxBadRecords = MaxBadRecords;
            }
            if (CreateDisposition != null)
            {
                loadRequest.CreateDisposition = EnumMap.ToApiValue(CreateDisposition.Value);
            }
            if (WriteDisposition != null)
            {
                loadRequest.WriteDisposition = EnumMap.ToApiValue(WriteDisposition.Value);
            }
            if (Autodetect != null)
            {
                loadRequest.Autodetect = Autodetect;
            }
            if (TimePartitioning != null)
            {
                loadRequest.TimePartitioning = TimePartitioning;
            }
            if (DestinationEncryptionConfiguration != null)
            {
                loadRequest.DestinationEncryptionConfiguration = DestinationEncryptionConfiguration;
            }
            if (DestinationSchemaUpdateOptions != null)
            {
                loadRequest.SchemaUpdateOptions = new List<string>(EnumMap.ToApiValues(DestinationSchemaUpdateOptions.Value));
            }
           ConfigurationModifier?.Invoke(loadRequest);
        }
    }
}
