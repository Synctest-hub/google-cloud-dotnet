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

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using gcdv = Google.Cloud.DiscoveryEngine.V1Beta;
using gcl = Google.Cloud.Location;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using gpr = Google.Protobuf.Reflection;
using sys = System;
using scg = System.Collections.Generic;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>Static class to provide extension methods to configure API clients.</summary>
    public static partial class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds a singleton <see cref="gcdv::CompletionServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddCompletionServiceClient(this IServiceCollection services, sys::Action<gcdv::CompletionServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::CompletionServiceClientBuilder builder = new gcdv::CompletionServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::ConversationalSearchServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddConversationalSearchServiceClient(this IServiceCollection services, sys::Action<gcdv::ConversationalSearchServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::ConversationalSearchServiceClientBuilder builder = new gcdv::ConversationalSearchServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::DataStoreServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDataStoreServiceClient(this IServiceCollection services, sys::Action<gcdv::DataStoreServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::DataStoreServiceClientBuilder builder = new gcdv::DataStoreServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::DocumentServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddDocumentServiceClient(this IServiceCollection services, sys::Action<gcdv::DocumentServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::DocumentServiceClientBuilder builder = new gcdv::DocumentServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::EngineServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddEngineServiceClient(this IServiceCollection services, sys::Action<gcdv::EngineServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::EngineServiceClientBuilder builder = new gcdv::EngineServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::GroundedGenerationServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddGroundedGenerationServiceClient(this IServiceCollection services, sys::Action<gcdv::GroundedGenerationServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::GroundedGenerationServiceClientBuilder builder = new gcdv::GroundedGenerationServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::RankServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRankServiceClient(this IServiceCollection services, sys::Action<gcdv::RankServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::RankServiceClientBuilder builder = new gcdv::RankServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::RecommendationServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRecommendationServiceClient(this IServiceCollection services, sys::Action<gcdv::RecommendationServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::RecommendationServiceClientBuilder builder = new gcdv::RecommendationServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::SchemaServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSchemaServiceClient(this IServiceCollection services, sys::Action<gcdv::SchemaServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::SchemaServiceClientBuilder builder = new gcdv::SchemaServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gcdv::SearchServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSearchServiceClient(this IServiceCollection services, sys::Action<gcdv::SearchServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::SearchServiceClientBuilder builder = new gcdv::SearchServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::SearchTuningServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSearchTuningServiceClient(this IServiceCollection services, sys::Action<gcdv::SearchTuningServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::SearchTuningServiceClientBuilder builder = new gcdv::SearchTuningServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::ServingConfigServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddServingConfigServiceClient(this IServiceCollection services, sys::Action<gcdv::ServingConfigServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::ServingConfigServiceClientBuilder builder = new gcdv::ServingConfigServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::SiteSearchEngineServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddSiteSearchEngineServiceClient(this IServiceCollection services, sys::Action<gcdv::SiteSearchEngineServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::SiteSearchEngineServiceClientBuilder builder = new gcdv::SiteSearchEngineServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gcdv::UserEventServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddUserEventServiceClient(this IServiceCollection services, sys::Action<gcdv::UserEventServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gcdv::UserEventServiceClientBuilder builder = new gcdv::UserEventServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });
    }
}
