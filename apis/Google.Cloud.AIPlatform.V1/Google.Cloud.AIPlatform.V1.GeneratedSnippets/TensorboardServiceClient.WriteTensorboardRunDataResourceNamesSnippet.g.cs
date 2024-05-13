// Copyright 2024 Google LLC
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

namespace GoogleCSharpSnippets
{
    // [START aiplatform_v1_generated_TensorboardService_WriteTensorboardRunData_sync_flattened_resourceNames]
    using Google.Cloud.AIPlatform.V1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using System.Collections.Generic;

    public sealed partial class GeneratedTensorboardServiceClientSnippets
    {
        /// <summary>Snippet for WriteTensorboardRunData</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void WriteTensorboardRunDataResourceNames()
        {
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardRunName tensorboardRun = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]");
            IEnumerable<TimeSeriesData> timeSeriesData = new TimeSeriesData[]
            {
                new TimeSeriesData
                {
                    TensorboardTimeSeriesId = "",
                    ValueType = TensorboardTimeSeries.Types.ValueType.Unspecified,
                    Values =
                    {
                        new TimeSeriesDataPoint
                        {
                            WallTime = new Timestamp
                            {
                                Seconds = 0L,
                                Nanos = 0,
                            },
                            Step = 0L,
                            Scalar = new Scalar { Value = 0, },
                            Tensor = new TensorboardTensor
                            {
                                Value = ByteString.Empty,
                                VersionNumber = 0,
                            },
                            Blobs = new TensorboardBlobSequence
                            {
                                Values =
                                {
                                    new TensorboardBlob
                                    {
                                        Id = "",
                                        Data = ByteString.Empty,
                                    },
                                },
                            },
                        },
                    },
                },
            };
            // Make the request
            WriteTensorboardRunDataResponse response = tensorboardServiceClient.WriteTensorboardRunData(tensorboardRun, timeSeriesData);
        }
    }
    // [END aiplatform_v1_generated_TensorboardService_WriteTensorboardRunData_sync_flattened_resourceNames]
}
