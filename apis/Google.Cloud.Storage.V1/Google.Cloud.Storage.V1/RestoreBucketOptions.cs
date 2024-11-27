// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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
using static Google.Apis.Storage.v1.BucketsResource;
using static Google.Apis.Storage.v1.BucketsResource.RestoreRequest;

namespace Google.Cloud.Storage.V1;

/// <summary>
/// Options for RestoreBucket operations.
/// </summary>
public sealed class RestoreBucketOptions
{
    /// <summary>
    /// The projection to retrieve.
    /// </summary>
    public Projection? Projection { get; set; }

    /// <summary>
    /// If set, this specifies the fields to fetch in the result to obtain partial responses,
    /// usually to improve performance.
    /// For example, to fetch just the name and location of each bucket, set this property to
    /// "items(name,location),nextPageToken". The "nextPageToken" field is required in order to
    /// fetch multiple pages; the library does not add this automatically.
    /// See https://cloud.google.com/storage/docs/json_api/v1/how-tos/performance#partial for more details
    /// on specifying fields for partial responses.
    /// </summary>
    public string Fields { get; set; }

    /// <summary>
    /// If set, this is the ID of the project which will be billed for the request.
    /// The caller must have suitable permissions for the project being billed.
    /// </summary>
    public string UserProject { get; set; }

    /// <summary>
    /// Options to pass custom retry configuration for each API request.
    /// </summary>
    public RetryOptions RetryOptions { get; set; }

    internal void ModifyRequest(RestoreRequest request)
    {
        if (Projection != null)
        {
            request.Projection = GaxPreconditions.CheckEnumValue((ProjectionEnum) Projection, nameof(Projection));
        }
        if (Fields != null)
        {
            request.Fields = Fields;
        }
        if (UserProject != null)
        {
            request.UserProject = UserProject;
        }

    }
}
