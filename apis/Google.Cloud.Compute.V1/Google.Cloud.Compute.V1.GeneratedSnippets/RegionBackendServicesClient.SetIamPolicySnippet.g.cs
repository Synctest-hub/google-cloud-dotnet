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
    // [START compute_v1_generated_RegionBackendServices_SetIamPolicy_sync_flattened]
    using Google.Cloud.Compute.V1;

    public sealed partial class GeneratedRegionBackendServicesClientSnippets
    {
        /// <summary>Snippet for SetIamPolicy</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void SetIamPolicy()
        {
            // Create client
            RegionBackendServicesClient regionBackendServicesClient = RegionBackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetPolicyRequest regionSetPolicyRequestResource = new RegionSetPolicyRequest
            {
                Etag = "",
                Policy = new Policy
                {
                    Etag = "",
                    Rules =
                    {
                        new Rule
                        {
                            Ins = { "", },
                            Permissions = { "", },
                            Conditions =
                            {
                                new Condition
                                {
                                    Op = "",
                                    Iam = "",
                                    Svc = "",
                                    Sys = "",
                                    Values = { "", },
                                },
                            },
                            LogConfigs =
                            {
                                new LogConfig
                                {
                                    DataAccess = new LogConfigDataAccessOptions { LogMode = "", },
                                    CloudAudit = new LogConfigCloudAuditOptions
                                    {
                                        AuthorizationLoggingOptions = new AuthorizationLoggingOptions { PermissionType = "", },
                                        LogName = "",
                                    },
                                    Counter = new LogConfigCounterOptions
                                    {
                                        Field = "",
                                        CustomFields =
                                        {
                                            new LogConfigCounterOptionsCustomField { Name = "", Value = "", },
                                        },
                                        Metric = "",
                                    },
                                },
                            },
                            Action = "",
                            Description = "",
                            NotIns = { "", },
                        },
                    },
                    AuditConfigs =
                    {
                        new AuditConfig
                        {
                            ExemptedMembers = { "", },
                            Service = "",
                            AuditLogConfigs =
                            {
                                new AuditLogConfig
                                {
                                    IgnoreChildExemptions = false,
                                    ExemptedMembers = { "", },
                                    LogType = "",
                                },
                            },
                        },
                    },
                    Version = 0,
                    Bindings =
                    {
                        new Binding
                        {
                            Role = "",
                            Condition = new Expr
                            {
                                Title = "",
                                Location = "",
                                Expression = "",
                                Description = "",
                            },
                            Members = { "", },
                            BindingId = "",
                        },
                    },
                    IamOwned = false,
                },
                Bindings =
                {
                    new Binding
                    {
                        Role = "",
                        Condition = new Expr
                        {
                            Title = "",
                            Location = "",
                            Expression = "",
                            Description = "",
                        },
                        Members = { "", },
                        BindingId = "",
                    },
                },
            };
            // Make the request
            Policy response = regionBackendServicesClient.SetIamPolicy(project, region, resource, regionSetPolicyRequestResource);
        }
    }
    // [END compute_v1_generated_RegionBackendServices_SetIamPolicy_sync_flattened]
}
