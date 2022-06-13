// Copyright 2022 Google LLC
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

// Generated code. DO NOT EDIT!

namespace Google.Cloud.GkeHub.V1Beta1.Snippets
{
    // [START gkehub_v1beta1_generated_GkeHubMembershipService_GenerateExclusivityManifest_sync]
    using Google.Cloud.GkeHub.V1Beta1;

    public sealed partial class GeneratedGkeHubMembershipServiceClientSnippets
    {
        /// <summary>Snippet for GenerateExclusivityManifest</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GenerateExclusivityManifestRequestObject()
        {
            // Create client
            GkeHubMembershipServiceClient gkeHubMembershipServiceClient = GkeHubMembershipServiceClient.Create();
            // Initialize request argument(s)
            GenerateExclusivityManifestRequest request = new GenerateExclusivityManifestRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                CrdManifest = "",
                CrManifest = "",
            };
            // Make the request
            GenerateExclusivityManifestResponse response = gkeHubMembershipServiceClient.GenerateExclusivityManifest(request);
        }
    }
    // [END gkehub_v1beta1_generated_GkeHubMembershipService_GenerateExclusivityManifest_sync]
}
