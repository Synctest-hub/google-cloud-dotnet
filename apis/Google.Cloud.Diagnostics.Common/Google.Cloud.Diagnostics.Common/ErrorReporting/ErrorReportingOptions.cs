﻿// Copyright 2017 Google Inc. All Rights Reserved.
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

using Google.Api;
using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using System;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Optional configuration to be used when initializing
    /// Google Cloud Error Reporting.
    /// </summary>
    public sealed class ErrorReportingOptions
    {
        /// <summary>The default log name, this is the log that error events will be written to.</summary>
        internal const string LogNameDefault = "stackdriver-error-reporting";

        /// <summary>The name of the log.</summary>
        public string LogName { get; }

        /// <summary>The monitored resource. See: https://cloud.google.com/logging/docs/api/v2/resource-list </summary>
        public MonitoredResource MonitoredResource { get; }

        /// <summary>The buffer options for the error reporter.</summary>
        public BufferOptions BufferOptions { get; }

        /// <summary>The retry options for the error reporter.</summary>
        public RetryOptions RetryOptions { get; }

        private ErrorReportingOptions(string logName, MonitoredResource resource, BufferOptions bufferOptions, RetryOptions retryOptions)
        {
            LogName = GaxPreconditions.CheckNotNullOrEmpty(logName, nameof(logName));
            MonitoredResource = GaxPreconditions.CheckNotNull(resource, nameof(resource));
            BufferOptions = GaxPreconditions.CheckNotNull(bufferOptions, nameof(bufferOptions));
            RetryOptions = GaxPreconditions.CheckNotNull(retryOptions, nameof(retryOptions));
        }

        /// <summary>
        /// Creates an <see cref="ErrorReportingOptions"/>.
        /// </summary>
        /// <param name="logName">The log name to log to. May be null, in which case, a default name will be used.</param>
        /// <param name="resource">The monitored resource. May be null, in which case an attempt will be made to
        /// automatically detected it. If it is not detected, it will default to the global resource.
        /// See: https://cloud.google.com/logging/docs/api/v2/resource-list </param>
        /// <param name="bufferOptions">The buffer options for the error reporter. Defaults to no buffer.</param>
        /// <param name="retryOptions">The retry options for the error reporter. Defaults to no retry.</param>
        /// <returns>A new <see cref="ErrorReportingOptions"/> instance with the specified parameters or defaults.</returns>
        public static ErrorReportingOptions Create(
            string logName = null, MonitoredResource resource = null, BufferOptions bufferOptions = null, RetryOptions retryOptions = null) =>
            new ErrorReportingOptions(
                logName ?? LogNameDefault,
                resource ?? MonitoredResourceBuilder.FromPlatform(),
                bufferOptions ?? BufferOptions.NoBuffer(),
                retryOptions ?? RetryOptions.NoRetry());
    }
}