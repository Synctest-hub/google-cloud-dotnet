// Copyright 2021 Google LLC
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

using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Compute.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedHealthChecksClientTest
    {
        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<HealthChecks.HealthChecksClient> mockGrpcClient = new moq::Mock<HealthChecks.HealthChecksClient>(moq::MockBehavior.Strict);
            DeleteHealthCheckRequest request = new DeleteHealthCheckRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                HealthCheck = "health_check13a16219",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Delete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HealthChecksClient client = new HealthChecksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<HealthChecks.HealthChecksClient> mockGrpcClient = new moq::Mock<HealthChecks.HealthChecksClient>(moq::MockBehavior.Strict);
            DeleteHealthCheckRequest request = new DeleteHealthCheckRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                HealthCheck = "health_check13a16219",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HealthChecksClient client = new HealthChecksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<HealthChecks.HealthChecksClient> mockGrpcClient = new moq::Mock<HealthChecks.HealthChecksClient>(moq::MockBehavior.Strict);
            DeleteHealthCheckRequest request = new DeleteHealthCheckRequest
            {
                Project = "projectaa6ff846",
                HealthCheck = "health_check13a16219",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Delete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HealthChecksClient client = new HealthChecksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.HealthCheck);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<HealthChecks.HealthChecksClient> mockGrpcClient = new moq::Mock<HealthChecks.HealthChecksClient>(moq::MockBehavior.Strict);
            DeleteHealthCheckRequest request = new DeleteHealthCheckRequest
            {
                Project = "projectaa6ff846",
                HealthCheck = "health_check13a16219",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HealthChecksClient client = new HealthChecksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.HealthCheck, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.HealthCheck, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<HealthChecks.HealthChecksClient> mockGrpcClient = new moq::Mock<HealthChecks.HealthChecksClient>(moq::MockBehavior.Strict);
            GetHealthCheckRequest request = new GetHealthCheckRequest
            {
                Project = "projectaa6ff846",
                HealthCheck = "health_check13a16219",
            };
            HealthCheck expectedResponse = new HealthCheck
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = HealthCheck.Types.Type.Tcp,
                Http2HealthCheck = new HTTP2HealthCheck(),
                CreationTimestamp = "creation_timestamp235e59a1",
                TimeoutSec = -1529270667,
                GrpcHealthCheck = new GRPCHealthCheck(),
                Region = "regionedb20d96",
                UnhealthyThreshold = -790413526,
                SslHealthCheck = new SSLHealthCheck(),
                CheckIntervalSec = 932847778,
                LogConfig = new HealthCheckLogConfig(),
                HealthyThreshold = -1266282289,
                HttpHealthCheck = new HTTPHealthCheck(),
                Description = "description2cf9da67",
                HttpsHealthCheck = new HTTPSHealthCheck(),
                SelfLink = "self_link7e87f12d",
                TcpHealthCheck = new TCPHealthCheck(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HealthChecksClient client = new HealthChecksClientImpl(mockGrpcClient.Object, null);
            HealthCheck response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<HealthChecks.HealthChecksClient> mockGrpcClient = new moq::Mock<HealthChecks.HealthChecksClient>(moq::MockBehavior.Strict);
            GetHealthCheckRequest request = new GetHealthCheckRequest
            {
                Project = "projectaa6ff846",
                HealthCheck = "health_check13a16219",
            };
            HealthCheck expectedResponse = new HealthCheck
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = HealthCheck.Types.Type.Tcp,
                Http2HealthCheck = new HTTP2HealthCheck(),
                CreationTimestamp = "creation_timestamp235e59a1",
                TimeoutSec = -1529270667,
                GrpcHealthCheck = new GRPCHealthCheck(),
                Region = "regionedb20d96",
                UnhealthyThreshold = -790413526,
                SslHealthCheck = new SSLHealthCheck(),
                CheckIntervalSec = 932847778,
                LogConfig = new HealthCheckLogConfig(),
                HealthyThreshold = -1266282289,
                HttpHealthCheck = new HTTPHealthCheck(),
                Description = "description2cf9da67",
                HttpsHealthCheck = new HTTPSHealthCheck(),
                SelfLink = "self_link7e87f12d",
                TcpHealthCheck = new TCPHealthCheck(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<HealthCheck>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HealthChecksClient client = new HealthChecksClientImpl(mockGrpcClient.Object, null);
            HealthCheck responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            HealthCheck responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<HealthChecks.HealthChecksClient> mockGrpcClient = new moq::Mock<HealthChecks.HealthChecksClient>(moq::MockBehavior.Strict);
            GetHealthCheckRequest request = new GetHealthCheckRequest
            {
                Project = "projectaa6ff846",
                HealthCheck = "health_check13a16219",
            };
            HealthCheck expectedResponse = new HealthCheck
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = HealthCheck.Types.Type.Tcp,
                Http2HealthCheck = new HTTP2HealthCheck(),
                CreationTimestamp = "creation_timestamp235e59a1",
                TimeoutSec = -1529270667,
                GrpcHealthCheck = new GRPCHealthCheck(),
                Region = "regionedb20d96",
                UnhealthyThreshold = -790413526,
                SslHealthCheck = new SSLHealthCheck(),
                CheckIntervalSec = 932847778,
                LogConfig = new HealthCheckLogConfig(),
                HealthyThreshold = -1266282289,
                HttpHealthCheck = new HTTPHealthCheck(),
                Description = "description2cf9da67",
                HttpsHealthCheck = new HTTPSHealthCheck(),
                SelfLink = "self_link7e87f12d",
                TcpHealthCheck = new TCPHealthCheck(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HealthChecksClient client = new HealthChecksClientImpl(mockGrpcClient.Object, null);
            HealthCheck response = client.Get(request.Project, request.HealthCheck);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<HealthChecks.HealthChecksClient> mockGrpcClient = new moq::Mock<HealthChecks.HealthChecksClient>(moq::MockBehavior.Strict);
            GetHealthCheckRequest request = new GetHealthCheckRequest
            {
                Project = "projectaa6ff846",
                HealthCheck = "health_check13a16219",
            };
            HealthCheck expectedResponse = new HealthCheck
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = HealthCheck.Types.Type.Tcp,
                Http2HealthCheck = new HTTP2HealthCheck(),
                CreationTimestamp = "creation_timestamp235e59a1",
                TimeoutSec = -1529270667,
                GrpcHealthCheck = new GRPCHealthCheck(),
                Region = "regionedb20d96",
                UnhealthyThreshold = -790413526,
                SslHealthCheck = new SSLHealthCheck(),
                CheckIntervalSec = 932847778,
                LogConfig = new HealthCheckLogConfig(),
                HealthyThreshold = -1266282289,
                HttpHealthCheck = new HTTPHealthCheck(),
                Description = "description2cf9da67",
                HttpsHealthCheck = new HTTPSHealthCheck(),
                SelfLink = "self_link7e87f12d",
                TcpHealthCheck = new TCPHealthCheck(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<HealthCheck>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HealthChecksClient client = new HealthChecksClientImpl(mockGrpcClient.Object, null);
            HealthCheck responseCallSettings = await client.GetAsync(request.Project, request.HealthCheck, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            HealthCheck responseCancellationToken = await client.GetAsync(request.Project, request.HealthCheck, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<HealthChecks.HealthChecksClient> mockGrpcClient = new moq::Mock<HealthChecks.HealthChecksClient>(moq::MockBehavior.Strict);
            InsertHealthCheckRequest request = new InsertHealthCheckRequest
            {
                RequestId = "request_id362c8df6",
                HealthCheckResource = new HealthCheck(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Insert(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HealthChecksClient client = new HealthChecksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<HealthChecks.HealthChecksClient> mockGrpcClient = new moq::Mock<HealthChecks.HealthChecksClient>(moq::MockBehavior.Strict);
            InsertHealthCheckRequest request = new InsertHealthCheckRequest
            {
                RequestId = "request_id362c8df6",
                HealthCheckResource = new HealthCheck(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.InsertAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HealthChecksClient client = new HealthChecksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<HealthChecks.HealthChecksClient> mockGrpcClient = new moq::Mock<HealthChecks.HealthChecksClient>(moq::MockBehavior.Strict);
            InsertHealthCheckRequest request = new InsertHealthCheckRequest
            {
                HealthCheckResource = new HealthCheck(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Insert(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HealthChecksClient client = new HealthChecksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.HealthCheckResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<HealthChecks.HealthChecksClient> mockGrpcClient = new moq::Mock<HealthChecks.HealthChecksClient>(moq::MockBehavior.Strict);
            InsertHealthCheckRequest request = new InsertHealthCheckRequest
            {
                HealthCheckResource = new HealthCheck(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.InsertAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HealthChecksClient client = new HealthChecksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.HealthCheckResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.HealthCheckResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchRequestObject()
        {
            moq::Mock<HealthChecks.HealthChecksClient> mockGrpcClient = new moq::Mock<HealthChecks.HealthChecksClient>(moq::MockBehavior.Strict);
            PatchHealthCheckRequest request = new PatchHealthCheckRequest
            {
                RequestId = "request_id362c8df6",
                HealthCheckResource = new HealthCheck(),
                Project = "projectaa6ff846",
                HealthCheck = "health_check13a16219",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Patch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HealthChecksClient client = new HealthChecksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchRequestObjectAsync()
        {
            moq::Mock<HealthChecks.HealthChecksClient> mockGrpcClient = new moq::Mock<HealthChecks.HealthChecksClient>(moq::MockBehavior.Strict);
            PatchHealthCheckRequest request = new PatchHealthCheckRequest
            {
                RequestId = "request_id362c8df6",
                HealthCheckResource = new HealthCheck(),
                Project = "projectaa6ff846",
                HealthCheck = "health_check13a16219",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.PatchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HealthChecksClient client = new HealthChecksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Patch()
        {
            moq::Mock<HealthChecks.HealthChecksClient> mockGrpcClient = new moq::Mock<HealthChecks.HealthChecksClient>(moq::MockBehavior.Strict);
            PatchHealthCheckRequest request = new PatchHealthCheckRequest
            {
                HealthCheckResource = new HealthCheck(),
                Project = "projectaa6ff846",
                HealthCheck = "health_check13a16219",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Patch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HealthChecksClient client = new HealthChecksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request.Project, request.HealthCheck, request.HealthCheckResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchAsync()
        {
            moq::Mock<HealthChecks.HealthChecksClient> mockGrpcClient = new moq::Mock<HealthChecks.HealthChecksClient>(moq::MockBehavior.Strict);
            PatchHealthCheckRequest request = new PatchHealthCheckRequest
            {
                HealthCheckResource = new HealthCheck(),
                Project = "projectaa6ff846",
                HealthCheck = "health_check13a16219",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.PatchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HealthChecksClient client = new HealthChecksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request.Project, request.HealthCheck, request.HealthCheckResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request.Project, request.HealthCheck, request.HealthCheckResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateRequestObject()
        {
            moq::Mock<HealthChecks.HealthChecksClient> mockGrpcClient = new moq::Mock<HealthChecks.HealthChecksClient>(moq::MockBehavior.Strict);
            UpdateHealthCheckRequest request = new UpdateHealthCheckRequest
            {
                RequestId = "request_id362c8df6",
                HealthCheckResource = new HealthCheck(),
                Project = "projectaa6ff846",
                HealthCheck = "health_check13a16219",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Update(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HealthChecksClient client = new HealthChecksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Update(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateRequestObjectAsync()
        {
            moq::Mock<HealthChecks.HealthChecksClient> mockGrpcClient = new moq::Mock<HealthChecks.HealthChecksClient>(moq::MockBehavior.Strict);
            UpdateHealthCheckRequest request = new UpdateHealthCheckRequest
            {
                RequestId = "request_id362c8df6",
                HealthCheckResource = new HealthCheck(),
                Project = "projectaa6ff846",
                HealthCheck = "health_check13a16219",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HealthChecksClient client = new HealthChecksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Update()
        {
            moq::Mock<HealthChecks.HealthChecksClient> mockGrpcClient = new moq::Mock<HealthChecks.HealthChecksClient>(moq::MockBehavior.Strict);
            UpdateHealthCheckRequest request = new UpdateHealthCheckRequest
            {
                HealthCheckResource = new HealthCheck(),
                Project = "projectaa6ff846",
                HealthCheck = "health_check13a16219",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Update(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HealthChecksClient client = new HealthChecksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Update(request.Project, request.HealthCheck, request.HealthCheckResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAsync()
        {
            moq::Mock<HealthChecks.HealthChecksClient> mockGrpcClient = new moq::Mock<HealthChecks.HealthChecksClient>(moq::MockBehavior.Strict);
            UpdateHealthCheckRequest request = new UpdateHealthCheckRequest
            {
                HealthCheckResource = new HealthCheck(),
                Project = "projectaa6ff846",
                HealthCheck = "health_check13a16219",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HealthChecksClient client = new HealthChecksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdateAsync(request.Project, request.HealthCheck, request.HealthCheckResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdateAsync(request.Project, request.HealthCheck, request.HealthCheckResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
