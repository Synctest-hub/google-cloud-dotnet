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

using System;
using Google.Api.Gax;
using static Google.Apis.Storage.v1.BucketsResource;
using static Google.Apis.Storage.v1.BucketsResource.GetRequest;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Options for <c>GetBucket</c> operations.
    /// </summary>
    public sealed class GetBucketOptions
    {
        /// <summary>
        /// Precondition for retrieval: the bucket is only fetched if its
        /// meta-generation matches the given value.
        /// </summary>
        public long? IfMetagenerationMatch { get; set; }

        /// <summary>
        /// Precondition for retrieval: the bucket is only fetched if its
        /// meta-generation does not match the given value.
        /// </summary>
        public long? IfMetagenerationNotMatch { get; set; }

        /// <summary>
        /// The projection to retrieve.
        /// </summary>
        public Projection? Projection { get; set; }

        /// <summary>
        /// If set, this is the ID of the project which will be billed for the request.
        /// The caller must have suitable permissions for the project being billed.
        /// </summary>
        public string UserProject { get; set; }

        /// <summary>
        /// Options to pass custom retry configuration for each API request.
        /// </summary>
        public RetryOptions RetryOptions { get; set; }

        /// <summary>
        /// (Optional) The bucket generation must be set (to retrieve a soft-deleted bucket) if soft_deleted is set to true.
        /// </summary>
        public long? Generation { get; set; }

        /// <summary>
        /// (Optional) Set to true to retrieve a soft-deleted bucket .It will return the bucket metadata only if the bucket exists and is in a soft-deleted state.
        /// The bucket generation must be set if soft_deleted is set to true
        /// </summary>
        public bool? SoftDeleted { get; set; }

        internal void ModifyRequest(GetRequest request)
        {
            if (IfMetagenerationMatch != null && IfMetagenerationNotMatch != null)
            {
                throw new ArgumentException($"Cannot specify {nameof(IfMetagenerationMatch)} and {nameof(IfMetagenerationNotMatch)} in the same options", "options");
            }

            if (Projection != null)
            {
                request.Projection = GaxPreconditions.CheckEnumValue((ProjectionEnum) Projection, nameof(Projection));
            }
            if (IfMetagenerationMatch != null)
            {
                request.IfMetagenerationMatch = IfMetagenerationMatch;
            }
            if (IfMetagenerationNotMatch != null)
            {
                request.IfMetagenerationNotMatch = IfMetagenerationNotMatch;
            }
            if (UserProject != null)
            {
                request.UserProject = UserProject;
            }
            if (Generation != null)
            {
                request.Generation = Generation;
            }
            if (SoftDeleted != null)
            {
               request.SoftDeleted = SoftDeleted;
            }
           
        }
    }
}
