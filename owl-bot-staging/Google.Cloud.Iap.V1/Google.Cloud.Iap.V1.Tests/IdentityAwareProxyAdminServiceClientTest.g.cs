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
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Iap.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedIdentityAwareProxyAdminServiceClientTest
    {
        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
                UpdateMask = new wkt::FieldMask(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
                UpdateMask = new wkt::FieldMask(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIapSettingsRequestObject()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            GetIapSettingsRequest request = new GetIapSettingsRequest
            {
                Name = "name1c9368b0",
            };
            IapSettings expectedResponse = new IapSettings
            {
                Name = "name1c9368b0",
                AccessSettings = new AccessSettings(),
                ApplicationSettings = new ApplicationSettings(),
            };
            mockGrpcClient.Setup(x => x.GetIapSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            IapSettings response = client.GetIapSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIapSettingsRequestObjectAsync()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            GetIapSettingsRequest request = new GetIapSettingsRequest
            {
                Name = "name1c9368b0",
            };
            IapSettings expectedResponse = new IapSettings
            {
                Name = "name1c9368b0",
                AccessSettings = new AccessSettings(),
                ApplicationSettings = new ApplicationSettings(),
            };
            mockGrpcClient.Setup(x => x.GetIapSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<IapSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            IapSettings responseCallSettings = await client.GetIapSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            IapSettings responseCancellationToken = await client.GetIapSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateIapSettingsRequestObject()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateIapSettingsRequest request = new UpdateIapSettingsRequest
            {
                IapSettings = new IapSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            IapSettings expectedResponse = new IapSettings
            {
                Name = "name1c9368b0",
                AccessSettings = new AccessSettings(),
                ApplicationSettings = new ApplicationSettings(),
            };
            mockGrpcClient.Setup(x => x.UpdateIapSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            IapSettings response = client.UpdateIapSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateIapSettingsRequestObjectAsync()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateIapSettingsRequest request = new UpdateIapSettingsRequest
            {
                IapSettings = new IapSettings(),
                UpdateMask = new wkt::FieldMask(),
            };
            IapSettings expectedResponse = new IapSettings
            {
                Name = "name1c9368b0",
                AccessSettings = new AccessSettings(),
                ApplicationSettings = new ApplicationSettings(),
            };
            mockGrpcClient.Setup(x => x.UpdateIapSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<IapSettings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            IapSettings responseCallSettings = await client.UpdateIapSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            IapSettings responseCancellationToken = await client.UpdateIapSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTunnelDestGroupRequestObject()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            CreateTunnelDestGroupRequest request = new CreateTunnelDestGroupRequest
            {
                ParentAsTunnelLocationName = TunnelLocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TunnelDestGroup = new TunnelDestGroup(),
                TunnelDestGroupId = "tunnel_dest_group_idad0d3bcc",
            };
            TunnelDestGroup expectedResponse = new TunnelDestGroup
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
                Cidrs = { "cidrs46409853", },
                Fqdns = { "fqdns28ae1f7a", },
            };
            mockGrpcClient.Setup(x => x.CreateTunnelDestGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            TunnelDestGroup response = client.CreateTunnelDestGroup(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTunnelDestGroupRequestObjectAsync()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            CreateTunnelDestGroupRequest request = new CreateTunnelDestGroupRequest
            {
                ParentAsTunnelLocationName = TunnelLocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TunnelDestGroup = new TunnelDestGroup(),
                TunnelDestGroupId = "tunnel_dest_group_idad0d3bcc",
            };
            TunnelDestGroup expectedResponse = new TunnelDestGroup
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
                Cidrs = { "cidrs46409853", },
                Fqdns = { "fqdns28ae1f7a", },
            };
            mockGrpcClient.Setup(x => x.CreateTunnelDestGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TunnelDestGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            TunnelDestGroup responseCallSettings = await client.CreateTunnelDestGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TunnelDestGroup responseCancellationToken = await client.CreateTunnelDestGroupAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTunnelDestGroup()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            CreateTunnelDestGroupRequest request = new CreateTunnelDestGroupRequest
            {
                ParentAsTunnelLocationName = TunnelLocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TunnelDestGroup = new TunnelDestGroup(),
                TunnelDestGroupId = "tunnel_dest_group_idad0d3bcc",
            };
            TunnelDestGroup expectedResponse = new TunnelDestGroup
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
                Cidrs = { "cidrs46409853", },
                Fqdns = { "fqdns28ae1f7a", },
            };
            mockGrpcClient.Setup(x => x.CreateTunnelDestGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            TunnelDestGroup response = client.CreateTunnelDestGroup(request.Parent, request.TunnelDestGroup, request.TunnelDestGroupId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTunnelDestGroupAsync()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            CreateTunnelDestGroupRequest request = new CreateTunnelDestGroupRequest
            {
                ParentAsTunnelLocationName = TunnelLocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TunnelDestGroup = new TunnelDestGroup(),
                TunnelDestGroupId = "tunnel_dest_group_idad0d3bcc",
            };
            TunnelDestGroup expectedResponse = new TunnelDestGroup
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
                Cidrs = { "cidrs46409853", },
                Fqdns = { "fqdns28ae1f7a", },
            };
            mockGrpcClient.Setup(x => x.CreateTunnelDestGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TunnelDestGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            TunnelDestGroup responseCallSettings = await client.CreateTunnelDestGroupAsync(request.Parent, request.TunnelDestGroup, request.TunnelDestGroupId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TunnelDestGroup responseCancellationToken = await client.CreateTunnelDestGroupAsync(request.Parent, request.TunnelDestGroup, request.TunnelDestGroupId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTunnelDestGroupResourceNames()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            CreateTunnelDestGroupRequest request = new CreateTunnelDestGroupRequest
            {
                ParentAsTunnelLocationName = TunnelLocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TunnelDestGroup = new TunnelDestGroup(),
                TunnelDestGroupId = "tunnel_dest_group_idad0d3bcc",
            };
            TunnelDestGroup expectedResponse = new TunnelDestGroup
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
                Cidrs = { "cidrs46409853", },
                Fqdns = { "fqdns28ae1f7a", },
            };
            mockGrpcClient.Setup(x => x.CreateTunnelDestGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            TunnelDestGroup response = client.CreateTunnelDestGroup(request.ParentAsTunnelLocationName, request.TunnelDestGroup, request.TunnelDestGroupId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTunnelDestGroupResourceNamesAsync()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            CreateTunnelDestGroupRequest request = new CreateTunnelDestGroupRequest
            {
                ParentAsTunnelLocationName = TunnelLocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TunnelDestGroup = new TunnelDestGroup(),
                TunnelDestGroupId = "tunnel_dest_group_idad0d3bcc",
            };
            TunnelDestGroup expectedResponse = new TunnelDestGroup
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
                Cidrs = { "cidrs46409853", },
                Fqdns = { "fqdns28ae1f7a", },
            };
            mockGrpcClient.Setup(x => x.CreateTunnelDestGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TunnelDestGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            TunnelDestGroup responseCallSettings = await client.CreateTunnelDestGroupAsync(request.ParentAsTunnelLocationName, request.TunnelDestGroup, request.TunnelDestGroupId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TunnelDestGroup responseCancellationToken = await client.CreateTunnelDestGroupAsync(request.ParentAsTunnelLocationName, request.TunnelDestGroup, request.TunnelDestGroupId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTunnelDestGroupRequestObject()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            GetTunnelDestGroupRequest request = new GetTunnelDestGroupRequest
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
            };
            TunnelDestGroup expectedResponse = new TunnelDestGroup
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
                Cidrs = { "cidrs46409853", },
                Fqdns = { "fqdns28ae1f7a", },
            };
            mockGrpcClient.Setup(x => x.GetTunnelDestGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            TunnelDestGroup response = client.GetTunnelDestGroup(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTunnelDestGroupRequestObjectAsync()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            GetTunnelDestGroupRequest request = new GetTunnelDestGroupRequest
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
            };
            TunnelDestGroup expectedResponse = new TunnelDestGroup
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
                Cidrs = { "cidrs46409853", },
                Fqdns = { "fqdns28ae1f7a", },
            };
            mockGrpcClient.Setup(x => x.GetTunnelDestGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TunnelDestGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            TunnelDestGroup responseCallSettings = await client.GetTunnelDestGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TunnelDestGroup responseCancellationToken = await client.GetTunnelDestGroupAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTunnelDestGroup()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            GetTunnelDestGroupRequest request = new GetTunnelDestGroupRequest
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
            };
            TunnelDestGroup expectedResponse = new TunnelDestGroup
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
                Cidrs = { "cidrs46409853", },
                Fqdns = { "fqdns28ae1f7a", },
            };
            mockGrpcClient.Setup(x => x.GetTunnelDestGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            TunnelDestGroup response = client.GetTunnelDestGroup(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTunnelDestGroupAsync()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            GetTunnelDestGroupRequest request = new GetTunnelDestGroupRequest
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
            };
            TunnelDestGroup expectedResponse = new TunnelDestGroup
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
                Cidrs = { "cidrs46409853", },
                Fqdns = { "fqdns28ae1f7a", },
            };
            mockGrpcClient.Setup(x => x.GetTunnelDestGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TunnelDestGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            TunnelDestGroup responseCallSettings = await client.GetTunnelDestGroupAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TunnelDestGroup responseCancellationToken = await client.GetTunnelDestGroupAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTunnelDestGroupResourceNames()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            GetTunnelDestGroupRequest request = new GetTunnelDestGroupRequest
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
            };
            TunnelDestGroup expectedResponse = new TunnelDestGroup
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
                Cidrs = { "cidrs46409853", },
                Fqdns = { "fqdns28ae1f7a", },
            };
            mockGrpcClient.Setup(x => x.GetTunnelDestGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            TunnelDestGroup response = client.GetTunnelDestGroup(request.TunnelDestGroupName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTunnelDestGroupResourceNamesAsync()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            GetTunnelDestGroupRequest request = new GetTunnelDestGroupRequest
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
            };
            TunnelDestGroup expectedResponse = new TunnelDestGroup
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
                Cidrs = { "cidrs46409853", },
                Fqdns = { "fqdns28ae1f7a", },
            };
            mockGrpcClient.Setup(x => x.GetTunnelDestGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TunnelDestGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            TunnelDestGroup responseCallSettings = await client.GetTunnelDestGroupAsync(request.TunnelDestGroupName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TunnelDestGroup responseCancellationToken = await client.GetTunnelDestGroupAsync(request.TunnelDestGroupName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTunnelDestGroupRequestObject()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteTunnelDestGroupRequest request = new DeleteTunnelDestGroupRequest
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTunnelDestGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteTunnelDestGroup(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTunnelDestGroupRequestObjectAsync()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteTunnelDestGroupRequest request = new DeleteTunnelDestGroupRequest
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTunnelDestGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteTunnelDestGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTunnelDestGroupAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTunnelDestGroup()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteTunnelDestGroupRequest request = new DeleteTunnelDestGroupRequest
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTunnelDestGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteTunnelDestGroup(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTunnelDestGroupAsync()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteTunnelDestGroupRequest request = new DeleteTunnelDestGroupRequest
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTunnelDestGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteTunnelDestGroupAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTunnelDestGroupAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTunnelDestGroupResourceNames()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteTunnelDestGroupRequest request = new DeleteTunnelDestGroupRequest
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTunnelDestGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteTunnelDestGroup(request.TunnelDestGroupName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTunnelDestGroupResourceNamesAsync()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            DeleteTunnelDestGroupRequest request = new DeleteTunnelDestGroupRequest
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTunnelDestGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteTunnelDestGroupAsync(request.TunnelDestGroupName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTunnelDestGroupAsync(request.TunnelDestGroupName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTunnelDestGroupRequestObject()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateTunnelDestGroupRequest request = new UpdateTunnelDestGroupRequest
            {
                TunnelDestGroup = new TunnelDestGroup(),
                UpdateMask = new wkt::FieldMask(),
            };
            TunnelDestGroup expectedResponse = new TunnelDestGroup
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
                Cidrs = { "cidrs46409853", },
                Fqdns = { "fqdns28ae1f7a", },
            };
            mockGrpcClient.Setup(x => x.UpdateTunnelDestGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            TunnelDestGroup response = client.UpdateTunnelDestGroup(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTunnelDestGroupRequestObjectAsync()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateTunnelDestGroupRequest request = new UpdateTunnelDestGroupRequest
            {
                TunnelDestGroup = new TunnelDestGroup(),
                UpdateMask = new wkt::FieldMask(),
            };
            TunnelDestGroup expectedResponse = new TunnelDestGroup
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
                Cidrs = { "cidrs46409853", },
                Fqdns = { "fqdns28ae1f7a", },
            };
            mockGrpcClient.Setup(x => x.UpdateTunnelDestGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TunnelDestGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            TunnelDestGroup responseCallSettings = await client.UpdateTunnelDestGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TunnelDestGroup responseCancellationToken = await client.UpdateTunnelDestGroupAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTunnelDestGroup()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateTunnelDestGroupRequest request = new UpdateTunnelDestGroupRequest
            {
                TunnelDestGroup = new TunnelDestGroup(),
                UpdateMask = new wkt::FieldMask(),
            };
            TunnelDestGroup expectedResponse = new TunnelDestGroup
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
                Cidrs = { "cidrs46409853", },
                Fqdns = { "fqdns28ae1f7a", },
            };
            mockGrpcClient.Setup(x => x.UpdateTunnelDestGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            TunnelDestGroup response = client.UpdateTunnelDestGroup(request.TunnelDestGroup, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTunnelDestGroupAsync()
        {
            moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient> mockGrpcClient = new moq::Mock<IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient>(moq::MockBehavior.Strict);
            UpdateTunnelDestGroupRequest request = new UpdateTunnelDestGroupRequest
            {
                TunnelDestGroup = new TunnelDestGroup(),
                UpdateMask = new wkt::FieldMask(),
            };
            TunnelDestGroup expectedResponse = new TunnelDestGroup
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
                Cidrs = { "cidrs46409853", },
                Fqdns = { "fqdns28ae1f7a", },
            };
            mockGrpcClient.Setup(x => x.UpdateTunnelDestGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TunnelDestGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IdentityAwareProxyAdminServiceClient client = new IdentityAwareProxyAdminServiceClientImpl(mockGrpcClient.Object, null, null);
            TunnelDestGroup responseCallSettings = await client.UpdateTunnelDestGroupAsync(request.TunnelDestGroup, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TunnelDestGroup responseCancellationToken = await client.UpdateTunnelDestGroupAsync(request.TunnelDestGroup, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
