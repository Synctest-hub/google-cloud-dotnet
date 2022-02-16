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

namespace Google.Cloud.AIPlatform.V1.Snippets
{
    // [START aiplatform_v1_generated_FeaturestoreService_CreateEntityType_sync]
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedFeaturestoreServiceClientSnippets
    {
        /// <summary>Snippet for CreateEntityType</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateEntityTypeRequestObject()
        {
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = FeaturestoreServiceClient.Create();
            // Initialize request argument(s)
            CreateEntityTypeRequest request = new CreateEntityTypeRequest
            {
                ParentAsFeaturestoreName = FeaturestoreName.FromProjectLocationFeaturestore("[PROJECT]", "[LOCATION]", "[FEATURESTORE]"),
                EntityType = new EntityType(),
                EntityTypeId = "",
            };
            // Make the request
            Operation<EntityType, CreateEntityTypeOperationMetadata> response = featurestoreServiceClient.CreateEntityType(request);

            // Poll until the returned long-running operation is complete
            Operation<EntityType, CreateEntityTypeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EntityType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EntityType, CreateEntityTypeOperationMetadata> retrievedResponse = featurestoreServiceClient.PollOnceCreateEntityType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EntityType retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END aiplatform_v1_generated_FeaturestoreService_CreateEntityType_sync]
}
