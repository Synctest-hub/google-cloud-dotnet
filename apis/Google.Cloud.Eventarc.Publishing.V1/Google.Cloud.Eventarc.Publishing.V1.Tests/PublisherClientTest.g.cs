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

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Eventarc.Publishing.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedPublisherClientTest
    {
        [xunit::FactAttribute]
        public void PublishChannelConnectionEventsRequestObject()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            PublishChannelConnectionEventsRequest request = new PublishChannelConnectionEventsRequest
            {
                ChannelConnection = "channel_connection1ad4645e",
                Events = { new wkt::Any(), },
                TextEvents =
                {
                    "text_events2754ee7c",
                },
            };
            PublishChannelConnectionEventsResponse expectedResponse = new PublishChannelConnectionEventsResponse { };
            mockGrpcClient.Setup(x => x.PublishChannelConnectionEvents(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null, null);
            PublishChannelConnectionEventsResponse response = client.PublishChannelConnectionEvents(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PublishChannelConnectionEventsRequestObjectAsync()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            PublishChannelConnectionEventsRequest request = new PublishChannelConnectionEventsRequest
            {
                ChannelConnection = "channel_connection1ad4645e",
                Events = { new wkt::Any(), },
                TextEvents =
                {
                    "text_events2754ee7c",
                },
            };
            PublishChannelConnectionEventsResponse expectedResponse = new PublishChannelConnectionEventsResponse { };
            mockGrpcClient.Setup(x => x.PublishChannelConnectionEventsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PublishChannelConnectionEventsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null, null);
            PublishChannelConnectionEventsResponse responseCallSettings = await client.PublishChannelConnectionEventsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PublishChannelConnectionEventsResponse responseCancellationToken = await client.PublishChannelConnectionEventsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PublishEventsRequestObject()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            PublishEventsRequest request = new PublishEventsRequest
            {
                Channel = "channeledd285c4",
                Events = { new wkt::Any(), },
                TextEvents =
                {
                    "text_events2754ee7c",
                },
            };
            PublishEventsResponse expectedResponse = new PublishEventsResponse { };
            mockGrpcClient.Setup(x => x.PublishEvents(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null, null);
            PublishEventsResponse response = client.PublishEvents(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PublishEventsRequestObjectAsync()
        {
            moq::Mock<Publisher.PublisherClient> mockGrpcClient = new moq::Mock<Publisher.PublisherClient>(moq::MockBehavior.Strict);
            PublishEventsRequest request = new PublishEventsRequest
            {
                Channel = "channeledd285c4",
                Events = { new wkt::Any(), },
                TextEvents =
                {
                    "text_events2754ee7c",
                },
            };
            PublishEventsResponse expectedResponse = new PublishEventsResponse { };
            mockGrpcClient.Setup(x => x.PublishEventsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PublishEventsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PublisherClient client = new PublisherClientImpl(mockGrpcClient.Object, null, null);
            PublishEventsResponse responseCallSettings = await client.PublishEventsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PublishEventsResponse responseCancellationToken = await client.PublishEventsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
