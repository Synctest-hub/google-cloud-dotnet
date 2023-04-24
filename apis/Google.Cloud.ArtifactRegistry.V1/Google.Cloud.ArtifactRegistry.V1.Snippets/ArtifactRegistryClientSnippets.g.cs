// Copyright 2023 Google LLC
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

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Iam.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcav = Google.Cloud.ArtifactRegistry.V1;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedArtifactRegistryClientSnippets
    {
        /// <summary>Snippet for ListDockerImages</summary>
        public void ListDockerImagesRequestObject()
        {
            // Snippet: ListDockerImages(ListDockerImagesRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::ListDockerImagesRequest request = new gcav::ListDockerImagesRequest
            {
                Parent = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcav::ListDockerImagesResponse, gcav::DockerImage> response = artifactRegistryClient.ListDockerImages(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::DockerImage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListDockerImagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::DockerImage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::DockerImage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::DockerImage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDockerImagesAsync</summary>
        public async Task ListDockerImagesRequestObjectAsync()
        {
            // Snippet: ListDockerImagesAsync(ListDockerImagesRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ListDockerImagesRequest request = new gcav::ListDockerImagesRequest
            {
                Parent = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcav::ListDockerImagesResponse, gcav::DockerImage> response = artifactRegistryClient.ListDockerImagesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::DockerImage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListDockerImagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::DockerImage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::DockerImage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::DockerImage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDockerImages</summary>
        public void ListDockerImages()
        {
            // Snippet: ListDockerImages(string, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<gcav::ListDockerImagesResponse, gcav::DockerImage> response = artifactRegistryClient.ListDockerImages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::DockerImage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListDockerImagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::DockerImage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::DockerImage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::DockerImage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDockerImagesAsync</summary>
        public async Task ListDockerImagesAsync()
        {
            // Snippet: ListDockerImagesAsync(string, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<gcav::ListDockerImagesResponse, gcav::DockerImage> response = artifactRegistryClient.ListDockerImagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::DockerImage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListDockerImagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::DockerImage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::DockerImage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::DockerImage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDockerImage</summary>
        public void GetDockerImageRequestObject()
        {
            // Snippet: GetDockerImage(GetDockerImageRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::GetDockerImageRequest request = new gcav::GetDockerImageRequest
            {
                DockerImageName = gcav::DockerImageName.FromProjectLocationRepositoryDockerImage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[DOCKER_IMAGE]"),
            };
            // Make the request
            gcav::DockerImage response = artifactRegistryClient.GetDockerImage(request);
            // End snippet
        }

        /// <summary>Snippet for GetDockerImageAsync</summary>
        public async Task GetDockerImageRequestObjectAsync()
        {
            // Snippet: GetDockerImageAsync(GetDockerImageRequest, CallSettings)
            // Additional: GetDockerImageAsync(GetDockerImageRequest, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::GetDockerImageRequest request = new gcav::GetDockerImageRequest
            {
                DockerImageName = gcav::DockerImageName.FromProjectLocationRepositoryDockerImage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[DOCKER_IMAGE]"),
            };
            // Make the request
            gcav::DockerImage response = await artifactRegistryClient.GetDockerImageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDockerImage</summary>
        public void GetDockerImage()
        {
            // Snippet: GetDockerImage(string, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/dockerImages/[DOCKER_IMAGE]";
            // Make the request
            gcav::DockerImage response = artifactRegistryClient.GetDockerImage(name);
            // End snippet
        }

        /// <summary>Snippet for GetDockerImageAsync</summary>
        public async Task GetDockerImageAsync()
        {
            // Snippet: GetDockerImageAsync(string, CallSettings)
            // Additional: GetDockerImageAsync(string, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/dockerImages/[DOCKER_IMAGE]";
            // Make the request
            gcav::DockerImage response = await artifactRegistryClient.GetDockerImageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDockerImage</summary>
        public void GetDockerImageResourceNames()
        {
            // Snippet: GetDockerImage(DockerImageName, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::DockerImageName name = gcav::DockerImageName.FromProjectLocationRepositoryDockerImage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[DOCKER_IMAGE]");
            // Make the request
            gcav::DockerImage response = artifactRegistryClient.GetDockerImage(name);
            // End snippet
        }

        /// <summary>Snippet for GetDockerImageAsync</summary>
        public async Task GetDockerImageResourceNamesAsync()
        {
            // Snippet: GetDockerImageAsync(DockerImageName, CallSettings)
            // Additional: GetDockerImageAsync(DockerImageName, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::DockerImageName name = gcav::DockerImageName.FromProjectLocationRepositoryDockerImage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[DOCKER_IMAGE]");
            // Make the request
            gcav::DockerImage response = await artifactRegistryClient.GetDockerImageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListMavenArtifacts</summary>
        public void ListMavenArtifactsRequestObject()
        {
            // Snippet: ListMavenArtifacts(ListMavenArtifactsRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::ListMavenArtifactsRequest request = new gcav::ListMavenArtifactsRequest
            {
                ParentAsRepositoryName = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedEnumerable<gcav::ListMavenArtifactsResponse, gcav::MavenArtifact> response = artifactRegistryClient.ListMavenArtifacts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::MavenArtifact item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListMavenArtifactsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::MavenArtifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::MavenArtifact> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::MavenArtifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMavenArtifactsAsync</summary>
        public async Task ListMavenArtifactsRequestObjectAsync()
        {
            // Snippet: ListMavenArtifactsAsync(ListMavenArtifactsRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ListMavenArtifactsRequest request = new gcav::ListMavenArtifactsRequest
            {
                ParentAsRepositoryName = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcav::ListMavenArtifactsResponse, gcav::MavenArtifact> response = artifactRegistryClient.ListMavenArtifactsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::MavenArtifact item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListMavenArtifactsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::MavenArtifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::MavenArtifact> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::MavenArtifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMavenArtifacts</summary>
        public void ListMavenArtifacts()
        {
            // Snippet: ListMavenArtifacts(string, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedEnumerable<gcav::ListMavenArtifactsResponse, gcav::MavenArtifact> response = artifactRegistryClient.ListMavenArtifacts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::MavenArtifact item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListMavenArtifactsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::MavenArtifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::MavenArtifact> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::MavenArtifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMavenArtifactsAsync</summary>
        public async Task ListMavenArtifactsAsync()
        {
            // Snippet: ListMavenArtifactsAsync(string, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedAsyncEnumerable<gcav::ListMavenArtifactsResponse, gcav::MavenArtifact> response = artifactRegistryClient.ListMavenArtifactsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::MavenArtifact item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListMavenArtifactsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::MavenArtifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::MavenArtifact> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::MavenArtifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMavenArtifacts</summary>
        public void ListMavenArtifactsResourceNames()
        {
            // Snippet: ListMavenArtifacts(RepositoryName, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::RepositoryName parent = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedEnumerable<gcav::ListMavenArtifactsResponse, gcav::MavenArtifact> response = artifactRegistryClient.ListMavenArtifacts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::MavenArtifact item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListMavenArtifactsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::MavenArtifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::MavenArtifact> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::MavenArtifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMavenArtifactsAsync</summary>
        public async Task ListMavenArtifactsResourceNamesAsync()
        {
            // Snippet: ListMavenArtifactsAsync(RepositoryName, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::RepositoryName parent = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedAsyncEnumerable<gcav::ListMavenArtifactsResponse, gcav::MavenArtifact> response = artifactRegistryClient.ListMavenArtifactsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::MavenArtifact item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListMavenArtifactsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::MavenArtifact item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::MavenArtifact> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::MavenArtifact item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetMavenArtifact</summary>
        public void GetMavenArtifactRequestObject()
        {
            // Snippet: GetMavenArtifact(GetMavenArtifactRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::GetMavenArtifactRequest request = new gcav::GetMavenArtifactRequest
            {
                MavenArtifactName = gcav::MavenArtifactName.FromProjectLocationRepositoryMavenArtifact("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[MAVEN_ARTIFACT]"),
            };
            // Make the request
            gcav::MavenArtifact response = artifactRegistryClient.GetMavenArtifact(request);
            // End snippet
        }

        /// <summary>Snippet for GetMavenArtifactAsync</summary>
        public async Task GetMavenArtifactRequestObjectAsync()
        {
            // Snippet: GetMavenArtifactAsync(GetMavenArtifactRequest, CallSettings)
            // Additional: GetMavenArtifactAsync(GetMavenArtifactRequest, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::GetMavenArtifactRequest request = new gcav::GetMavenArtifactRequest
            {
                MavenArtifactName = gcav::MavenArtifactName.FromProjectLocationRepositoryMavenArtifact("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[MAVEN_ARTIFACT]"),
            };
            // Make the request
            gcav::MavenArtifact response = await artifactRegistryClient.GetMavenArtifactAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMavenArtifact</summary>
        public void GetMavenArtifact()
        {
            // Snippet: GetMavenArtifact(string, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/mavenArtifacts/[MAVEN_ARTIFACT]";
            // Make the request
            gcav::MavenArtifact response = artifactRegistryClient.GetMavenArtifact(name);
            // End snippet
        }

        /// <summary>Snippet for GetMavenArtifactAsync</summary>
        public async Task GetMavenArtifactAsync()
        {
            // Snippet: GetMavenArtifactAsync(string, CallSettings)
            // Additional: GetMavenArtifactAsync(string, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/mavenArtifacts/[MAVEN_ARTIFACT]";
            // Make the request
            gcav::MavenArtifact response = await artifactRegistryClient.GetMavenArtifactAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMavenArtifact</summary>
        public void GetMavenArtifactResourceNames()
        {
            // Snippet: GetMavenArtifact(MavenArtifactName, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::MavenArtifactName name = gcav::MavenArtifactName.FromProjectLocationRepositoryMavenArtifact("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[MAVEN_ARTIFACT]");
            // Make the request
            gcav::MavenArtifact response = artifactRegistryClient.GetMavenArtifact(name);
            // End snippet
        }

        /// <summary>Snippet for GetMavenArtifactAsync</summary>
        public async Task GetMavenArtifactResourceNamesAsync()
        {
            // Snippet: GetMavenArtifactAsync(MavenArtifactName, CallSettings)
            // Additional: GetMavenArtifactAsync(MavenArtifactName, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::MavenArtifactName name = gcav::MavenArtifactName.FromProjectLocationRepositoryMavenArtifact("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[MAVEN_ARTIFACT]");
            // Make the request
            gcav::MavenArtifact response = await artifactRegistryClient.GetMavenArtifactAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListNpmPackages</summary>
        public void ListNpmPackagesRequestObject()
        {
            // Snippet: ListNpmPackages(ListNpmPackagesRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::ListNpmPackagesRequest request = new gcav::ListNpmPackagesRequest
            {
                ParentAsRepositoryName = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedEnumerable<gcav::ListNpmPackagesResponse, gcav::NpmPackage> response = artifactRegistryClient.ListNpmPackages(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::NpmPackage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListNpmPackagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::NpmPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::NpmPackage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::NpmPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNpmPackagesAsync</summary>
        public async Task ListNpmPackagesRequestObjectAsync()
        {
            // Snippet: ListNpmPackagesAsync(ListNpmPackagesRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ListNpmPackagesRequest request = new gcav::ListNpmPackagesRequest
            {
                ParentAsRepositoryName = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcav::ListNpmPackagesResponse, gcav::NpmPackage> response = artifactRegistryClient.ListNpmPackagesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::NpmPackage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListNpmPackagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::NpmPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::NpmPackage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::NpmPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNpmPackages</summary>
        public void ListNpmPackages()
        {
            // Snippet: ListNpmPackages(string, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedEnumerable<gcav::ListNpmPackagesResponse, gcav::NpmPackage> response = artifactRegistryClient.ListNpmPackages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::NpmPackage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListNpmPackagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::NpmPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::NpmPackage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::NpmPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNpmPackagesAsync</summary>
        public async Task ListNpmPackagesAsync()
        {
            // Snippet: ListNpmPackagesAsync(string, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedAsyncEnumerable<gcav::ListNpmPackagesResponse, gcav::NpmPackage> response = artifactRegistryClient.ListNpmPackagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::NpmPackage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListNpmPackagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::NpmPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::NpmPackage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::NpmPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNpmPackages</summary>
        public void ListNpmPackagesResourceNames()
        {
            // Snippet: ListNpmPackages(RepositoryName, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::RepositoryName parent = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedEnumerable<gcav::ListNpmPackagesResponse, gcav::NpmPackage> response = artifactRegistryClient.ListNpmPackages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::NpmPackage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListNpmPackagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::NpmPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::NpmPackage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::NpmPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNpmPackagesAsync</summary>
        public async Task ListNpmPackagesResourceNamesAsync()
        {
            // Snippet: ListNpmPackagesAsync(RepositoryName, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::RepositoryName parent = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedAsyncEnumerable<gcav::ListNpmPackagesResponse, gcav::NpmPackage> response = artifactRegistryClient.ListNpmPackagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::NpmPackage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListNpmPackagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::NpmPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::NpmPackage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::NpmPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetNpmPackage</summary>
        public void GetNpmPackageRequestObject()
        {
            // Snippet: GetNpmPackage(GetNpmPackageRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::GetNpmPackageRequest request = new gcav::GetNpmPackageRequest
            {
                NpmPackageName = gcav::NpmPackageName.FromProjectLocationRepositoryNpmPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[NPM_PACKAGE]"),
            };
            // Make the request
            gcav::NpmPackage response = artifactRegistryClient.GetNpmPackage(request);
            // End snippet
        }

        /// <summary>Snippet for GetNpmPackageAsync</summary>
        public async Task GetNpmPackageRequestObjectAsync()
        {
            // Snippet: GetNpmPackageAsync(GetNpmPackageRequest, CallSettings)
            // Additional: GetNpmPackageAsync(GetNpmPackageRequest, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::GetNpmPackageRequest request = new gcav::GetNpmPackageRequest
            {
                NpmPackageName = gcav::NpmPackageName.FromProjectLocationRepositoryNpmPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[NPM_PACKAGE]"),
            };
            // Make the request
            gcav::NpmPackage response = await artifactRegistryClient.GetNpmPackageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNpmPackage</summary>
        public void GetNpmPackage()
        {
            // Snippet: GetNpmPackage(string, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/npmPackages/[NPM_PACKAGE]";
            // Make the request
            gcav::NpmPackage response = artifactRegistryClient.GetNpmPackage(name);
            // End snippet
        }

        /// <summary>Snippet for GetNpmPackageAsync</summary>
        public async Task GetNpmPackageAsync()
        {
            // Snippet: GetNpmPackageAsync(string, CallSettings)
            // Additional: GetNpmPackageAsync(string, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/npmPackages/[NPM_PACKAGE]";
            // Make the request
            gcav::NpmPackage response = await artifactRegistryClient.GetNpmPackageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNpmPackage</summary>
        public void GetNpmPackageResourceNames()
        {
            // Snippet: GetNpmPackage(NpmPackageName, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::NpmPackageName name = gcav::NpmPackageName.FromProjectLocationRepositoryNpmPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[NPM_PACKAGE]");
            // Make the request
            gcav::NpmPackage response = artifactRegistryClient.GetNpmPackage(name);
            // End snippet
        }

        /// <summary>Snippet for GetNpmPackageAsync</summary>
        public async Task GetNpmPackageResourceNamesAsync()
        {
            // Snippet: GetNpmPackageAsync(NpmPackageName, CallSettings)
            // Additional: GetNpmPackageAsync(NpmPackageName, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::NpmPackageName name = gcav::NpmPackageName.FromProjectLocationRepositoryNpmPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[NPM_PACKAGE]");
            // Make the request
            gcav::NpmPackage response = await artifactRegistryClient.GetNpmPackageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPythonPackages</summary>
        public void ListPythonPackagesRequestObject()
        {
            // Snippet: ListPythonPackages(ListPythonPackagesRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::ListPythonPackagesRequest request = new gcav::ListPythonPackagesRequest
            {
                ParentAsRepositoryName = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedEnumerable<gcav::ListPythonPackagesResponse, gcav::PythonPackage> response = artifactRegistryClient.ListPythonPackages(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::PythonPackage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListPythonPackagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::PythonPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::PythonPackage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::PythonPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPythonPackagesAsync</summary>
        public async Task ListPythonPackagesRequestObjectAsync()
        {
            // Snippet: ListPythonPackagesAsync(ListPythonPackagesRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ListPythonPackagesRequest request = new gcav::ListPythonPackagesRequest
            {
                ParentAsRepositoryName = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcav::ListPythonPackagesResponse, gcav::PythonPackage> response = artifactRegistryClient.ListPythonPackagesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::PythonPackage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListPythonPackagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::PythonPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::PythonPackage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::PythonPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPythonPackages</summary>
        public void ListPythonPackages()
        {
            // Snippet: ListPythonPackages(string, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedEnumerable<gcav::ListPythonPackagesResponse, gcav::PythonPackage> response = artifactRegistryClient.ListPythonPackages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::PythonPackage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListPythonPackagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::PythonPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::PythonPackage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::PythonPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPythonPackagesAsync</summary>
        public async Task ListPythonPackagesAsync()
        {
            // Snippet: ListPythonPackagesAsync(string, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedAsyncEnumerable<gcav::ListPythonPackagesResponse, gcav::PythonPackage> response = artifactRegistryClient.ListPythonPackagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::PythonPackage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListPythonPackagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::PythonPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::PythonPackage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::PythonPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPythonPackages</summary>
        public void ListPythonPackagesResourceNames()
        {
            // Snippet: ListPythonPackages(RepositoryName, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::RepositoryName parent = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedEnumerable<gcav::ListPythonPackagesResponse, gcav::PythonPackage> response = artifactRegistryClient.ListPythonPackages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::PythonPackage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListPythonPackagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::PythonPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::PythonPackage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::PythonPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPythonPackagesAsync</summary>
        public async Task ListPythonPackagesResourceNamesAsync()
        {
            // Snippet: ListPythonPackagesAsync(RepositoryName, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::RepositoryName parent = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedAsyncEnumerable<gcav::ListPythonPackagesResponse, gcav::PythonPackage> response = artifactRegistryClient.ListPythonPackagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::PythonPackage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListPythonPackagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::PythonPackage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::PythonPackage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::PythonPackage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetPythonPackage</summary>
        public void GetPythonPackageRequestObject()
        {
            // Snippet: GetPythonPackage(GetPythonPackageRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::GetPythonPackageRequest request = new gcav::GetPythonPackageRequest
            {
                PythonPackageName = gcav::PythonPackageName.FromProjectLocationRepositoryPythonPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PYTHON_PACKAGE]"),
            };
            // Make the request
            gcav::PythonPackage response = artifactRegistryClient.GetPythonPackage(request);
            // End snippet
        }

        /// <summary>Snippet for GetPythonPackageAsync</summary>
        public async Task GetPythonPackageRequestObjectAsync()
        {
            // Snippet: GetPythonPackageAsync(GetPythonPackageRequest, CallSettings)
            // Additional: GetPythonPackageAsync(GetPythonPackageRequest, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::GetPythonPackageRequest request = new gcav::GetPythonPackageRequest
            {
                PythonPackageName = gcav::PythonPackageName.FromProjectLocationRepositoryPythonPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PYTHON_PACKAGE]"),
            };
            // Make the request
            gcav::PythonPackage response = await artifactRegistryClient.GetPythonPackageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPythonPackage</summary>
        public void GetPythonPackage()
        {
            // Snippet: GetPythonPackage(string, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pythonPackages/[PYTHON_PACKAGE]";
            // Make the request
            gcav::PythonPackage response = artifactRegistryClient.GetPythonPackage(name);
            // End snippet
        }

        /// <summary>Snippet for GetPythonPackageAsync</summary>
        public async Task GetPythonPackageAsync()
        {
            // Snippet: GetPythonPackageAsync(string, CallSettings)
            // Additional: GetPythonPackageAsync(string, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pythonPackages/[PYTHON_PACKAGE]";
            // Make the request
            gcav::PythonPackage response = await artifactRegistryClient.GetPythonPackageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPythonPackage</summary>
        public void GetPythonPackageResourceNames()
        {
            // Snippet: GetPythonPackage(PythonPackageName, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::PythonPackageName name = gcav::PythonPackageName.FromProjectLocationRepositoryPythonPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PYTHON_PACKAGE]");
            // Make the request
            gcav::PythonPackage response = artifactRegistryClient.GetPythonPackage(name);
            // End snippet
        }

        /// <summary>Snippet for GetPythonPackageAsync</summary>
        public async Task GetPythonPackageResourceNamesAsync()
        {
            // Snippet: GetPythonPackageAsync(PythonPackageName, CallSettings)
            // Additional: GetPythonPackageAsync(PythonPackageName, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::PythonPackageName name = gcav::PythonPackageName.FromProjectLocationRepositoryPythonPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PYTHON_PACKAGE]");
            // Make the request
            gcav::PythonPackage response = await artifactRegistryClient.GetPythonPackageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ImportAptArtifacts</summary>
        public void ImportAptArtifactsRequestObject()
        {
            // Snippet: ImportAptArtifacts(ImportAptArtifactsRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::ImportAptArtifactsRequest request = new gcav::ImportAptArtifactsRequest
            {
                Parent = "",
                GcsSource = new gcav::ImportAptArtifactsGcsSource(),
            };
            // Make the request
            Operation<gcav::ImportAptArtifactsResponse, gcav::ImportAptArtifactsMetadata> response = artifactRegistryClient.ImportAptArtifacts(request);

            // Poll until the returned long-running operation is complete
            Operation<gcav::ImportAptArtifactsResponse, gcav::ImportAptArtifactsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcav::ImportAptArtifactsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::ImportAptArtifactsResponse, gcav::ImportAptArtifactsMetadata> retrievedResponse = artifactRegistryClient.PollOnceImportAptArtifacts(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::ImportAptArtifactsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportAptArtifactsAsync</summary>
        public async Task ImportAptArtifactsRequestObjectAsync()
        {
            // Snippet: ImportAptArtifactsAsync(ImportAptArtifactsRequest, CallSettings)
            // Additional: ImportAptArtifactsAsync(ImportAptArtifactsRequest, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ImportAptArtifactsRequest request = new gcav::ImportAptArtifactsRequest
            {
                Parent = "",
                GcsSource = new gcav::ImportAptArtifactsGcsSource(),
            };
            // Make the request
            Operation<gcav::ImportAptArtifactsResponse, gcav::ImportAptArtifactsMetadata> response = await artifactRegistryClient.ImportAptArtifactsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcav::ImportAptArtifactsResponse, gcav::ImportAptArtifactsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcav::ImportAptArtifactsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::ImportAptArtifactsResponse, gcav::ImportAptArtifactsMetadata> retrievedResponse = await artifactRegistryClient.PollOnceImportAptArtifactsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::ImportAptArtifactsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportYumArtifacts</summary>
        public void ImportYumArtifactsRequestObject()
        {
            // Snippet: ImportYumArtifacts(ImportYumArtifactsRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::ImportYumArtifactsRequest request = new gcav::ImportYumArtifactsRequest
            {
                Parent = "",
                GcsSource = new gcav::ImportYumArtifactsGcsSource(),
            };
            // Make the request
            Operation<gcav::ImportYumArtifactsResponse, gcav::ImportYumArtifactsMetadata> response = artifactRegistryClient.ImportYumArtifacts(request);

            // Poll until the returned long-running operation is complete
            Operation<gcav::ImportYumArtifactsResponse, gcav::ImportYumArtifactsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcav::ImportYumArtifactsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::ImportYumArtifactsResponse, gcav::ImportYumArtifactsMetadata> retrievedResponse = artifactRegistryClient.PollOnceImportYumArtifacts(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::ImportYumArtifactsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportYumArtifactsAsync</summary>
        public async Task ImportYumArtifactsRequestObjectAsync()
        {
            // Snippet: ImportYumArtifactsAsync(ImportYumArtifactsRequest, CallSettings)
            // Additional: ImportYumArtifactsAsync(ImportYumArtifactsRequest, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ImportYumArtifactsRequest request = new gcav::ImportYumArtifactsRequest
            {
                Parent = "",
                GcsSource = new gcav::ImportYumArtifactsGcsSource(),
            };
            // Make the request
            Operation<gcav::ImportYumArtifactsResponse, gcav::ImportYumArtifactsMetadata> response = await artifactRegistryClient.ImportYumArtifactsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcav::ImportYumArtifactsResponse, gcav::ImportYumArtifactsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcav::ImportYumArtifactsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::ImportYumArtifactsResponse, gcav::ImportYumArtifactsMetadata> retrievedResponse = await artifactRegistryClient.PollOnceImportYumArtifactsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::ImportYumArtifactsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListRepositories</summary>
        public void ListRepositoriesRequestObject()
        {
            // Snippet: ListRepositories(ListRepositoriesRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::ListRepositoriesRequest request = new gcav::ListRepositoriesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<gcav::ListRepositoriesResponse, gcav::Repository> response = artifactRegistryClient.ListRepositories(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Repository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListRepositoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Repository> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositoriesAsync</summary>
        public async Task ListRepositoriesRequestObjectAsync()
        {
            // Snippet: ListRepositoriesAsync(ListRepositoriesRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ListRepositoriesRequest request = new gcav::ListRepositoriesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcav::ListRepositoriesResponse, gcav::Repository> response = artifactRegistryClient.ListRepositoriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Repository item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListRepositoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Repository> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositories</summary>
        public void ListRepositories()
        {
            // Snippet: ListRepositories(string, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcav::ListRepositoriesResponse, gcav::Repository> response = artifactRegistryClient.ListRepositories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Repository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListRepositoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Repository> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositoriesAsync</summary>
        public async Task ListRepositoriesAsync()
        {
            // Snippet: ListRepositoriesAsync(string, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcav::ListRepositoriesResponse, gcav::Repository> response = artifactRegistryClient.ListRepositoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Repository item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListRepositoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Repository> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositories</summary>
        public void ListRepositoriesResourceNames()
        {
            // Snippet: ListRepositories(LocationName, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcav::ListRepositoriesResponse, gcav::Repository> response = artifactRegistryClient.ListRepositories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Repository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListRepositoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Repository> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositoriesAsync</summary>
        public async Task ListRepositoriesResourceNamesAsync()
        {
            // Snippet: ListRepositoriesAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcav::ListRepositoriesResponse, gcav::Repository> response = artifactRegistryClient.ListRepositoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Repository item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListRepositoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Repository> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRepository</summary>
        public void GetRepositoryRequestObject()
        {
            // Snippet: GetRepository(GetRepositoryRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::GetRepositoryRequest request = new gcav::GetRepositoryRequest
            {
                RepositoryName = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            gcav::Repository response = artifactRegistryClient.GetRepository(request);
            // End snippet
        }

        /// <summary>Snippet for GetRepositoryAsync</summary>
        public async Task GetRepositoryRequestObjectAsync()
        {
            // Snippet: GetRepositoryAsync(GetRepositoryRequest, CallSettings)
            // Additional: GetRepositoryAsync(GetRepositoryRequest, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::GetRepositoryRequest request = new gcav::GetRepositoryRequest
            {
                RepositoryName = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            gcav::Repository response = await artifactRegistryClient.GetRepositoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRepository</summary>
        public void GetRepository()
        {
            // Snippet: GetRepository(string, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            gcav::Repository response = artifactRegistryClient.GetRepository(name);
            // End snippet
        }

        /// <summary>Snippet for GetRepositoryAsync</summary>
        public async Task GetRepositoryAsync()
        {
            // Snippet: GetRepositoryAsync(string, CallSettings)
            // Additional: GetRepositoryAsync(string, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            gcav::Repository response = await artifactRegistryClient.GetRepositoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRepository</summary>
        public void GetRepositoryResourceNames()
        {
            // Snippet: GetRepository(RepositoryName, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::RepositoryName name = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            gcav::Repository response = artifactRegistryClient.GetRepository(name);
            // End snippet
        }

        /// <summary>Snippet for GetRepositoryAsync</summary>
        public async Task GetRepositoryResourceNamesAsync()
        {
            // Snippet: GetRepositoryAsync(RepositoryName, CallSettings)
            // Additional: GetRepositoryAsync(RepositoryName, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::RepositoryName name = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            gcav::Repository response = await artifactRegistryClient.GetRepositoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateRepository</summary>
        public void CreateRepositoryRequestObject()
        {
            // Snippet: CreateRepository(CreateRepositoryRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::CreateRepositoryRequest request = new gcav::CreateRepositoryRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                RepositoryId = "",
                Repository = new gcav::Repository(),
            };
            // Make the request
            Operation<gcav::Repository, gcav::OperationMetadata> response = artifactRegistryClient.CreateRepository(request);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Repository, gcav::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcav::Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Repository, gcav::OperationMetadata> retrievedResponse = artifactRegistryClient.PollOnceCreateRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Repository retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRepositoryAsync</summary>
        public async Task CreateRepositoryRequestObjectAsync()
        {
            // Snippet: CreateRepositoryAsync(CreateRepositoryRequest, CallSettings)
            // Additional: CreateRepositoryAsync(CreateRepositoryRequest, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::CreateRepositoryRequest request = new gcav::CreateRepositoryRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                RepositoryId = "",
                Repository = new gcav::Repository(),
            };
            // Make the request
            Operation<gcav::Repository, gcav::OperationMetadata> response = await artifactRegistryClient.CreateRepositoryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Repository, gcav::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcav::Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Repository, gcav::OperationMetadata> retrievedResponse = await artifactRegistryClient.PollOnceCreateRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Repository retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRepository</summary>
        public void CreateRepository()
        {
            // Snippet: CreateRepository(string, Repository, string, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcav::Repository repository = new gcav::Repository();
            string repositoryId = "";
            // Make the request
            Operation<gcav::Repository, gcav::OperationMetadata> response = artifactRegistryClient.CreateRepository(parent, repository, repositoryId);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Repository, gcav::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcav::Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Repository, gcav::OperationMetadata> retrievedResponse = artifactRegistryClient.PollOnceCreateRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Repository retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRepositoryAsync</summary>
        public async Task CreateRepositoryAsync()
        {
            // Snippet: CreateRepositoryAsync(string, Repository, string, CallSettings)
            // Additional: CreateRepositoryAsync(string, Repository, string, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcav::Repository repository = new gcav::Repository();
            string repositoryId = "";
            // Make the request
            Operation<gcav::Repository, gcav::OperationMetadata> response = await artifactRegistryClient.CreateRepositoryAsync(parent, repository, repositoryId);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Repository, gcav::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcav::Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Repository, gcav::OperationMetadata> retrievedResponse = await artifactRegistryClient.PollOnceCreateRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Repository retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRepository</summary>
        public void CreateRepositoryResourceNames()
        {
            // Snippet: CreateRepository(LocationName, Repository, string, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcav::Repository repository = new gcav::Repository();
            string repositoryId = "";
            // Make the request
            Operation<gcav::Repository, gcav::OperationMetadata> response = artifactRegistryClient.CreateRepository(parent, repository, repositoryId);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Repository, gcav::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcav::Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Repository, gcav::OperationMetadata> retrievedResponse = artifactRegistryClient.PollOnceCreateRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Repository retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRepositoryAsync</summary>
        public async Task CreateRepositoryResourceNamesAsync()
        {
            // Snippet: CreateRepositoryAsync(LocationName, Repository, string, CallSettings)
            // Additional: CreateRepositoryAsync(LocationName, Repository, string, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcav::Repository repository = new gcav::Repository();
            string repositoryId = "";
            // Make the request
            Operation<gcav::Repository, gcav::OperationMetadata> response = await artifactRegistryClient.CreateRepositoryAsync(parent, repository, repositoryId);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Repository, gcav::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcav::Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Repository, gcav::OperationMetadata> retrievedResponse = await artifactRegistryClient.PollOnceCreateRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Repository retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRepository</summary>
        public void UpdateRepositoryRequestObject()
        {
            // Snippet: UpdateRepository(UpdateRepositoryRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::UpdateRepositoryRequest request = new gcav::UpdateRepositoryRequest
            {
                Repository = new gcav::Repository(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcav::Repository response = artifactRegistryClient.UpdateRepository(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRepositoryAsync</summary>
        public async Task UpdateRepositoryRequestObjectAsync()
        {
            // Snippet: UpdateRepositoryAsync(UpdateRepositoryRequest, CallSettings)
            // Additional: UpdateRepositoryAsync(UpdateRepositoryRequest, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::UpdateRepositoryRequest request = new gcav::UpdateRepositoryRequest
            {
                Repository = new gcav::Repository(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcav::Repository response = await artifactRegistryClient.UpdateRepositoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRepository</summary>
        public void UpdateRepository()
        {
            // Snippet: UpdateRepository(Repository, FieldMask, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::Repository repository = new gcav::Repository();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcav::Repository response = artifactRegistryClient.UpdateRepository(repository, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateRepositoryAsync</summary>
        public async Task UpdateRepositoryAsync()
        {
            // Snippet: UpdateRepositoryAsync(Repository, FieldMask, CallSettings)
            // Additional: UpdateRepositoryAsync(Repository, FieldMask, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::Repository repository = new gcav::Repository();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcav::Repository response = await artifactRegistryClient.UpdateRepositoryAsync(repository, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteRepository</summary>
        public void DeleteRepositoryRequestObject()
        {
            // Snippet: DeleteRepository(DeleteRepositoryRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::DeleteRepositoryRequest request = new gcav::DeleteRepositoryRequest
            {
                RepositoryName = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            Operation<Empty, gcav::OperationMetadata> response = artifactRegistryClient.DeleteRepository(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcav::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcav::OperationMetadata> retrievedResponse = artifactRegistryClient.PollOnceDeleteRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRepositoryAsync</summary>
        public async Task DeleteRepositoryRequestObjectAsync()
        {
            // Snippet: DeleteRepositoryAsync(DeleteRepositoryRequest, CallSettings)
            // Additional: DeleteRepositoryAsync(DeleteRepositoryRequest, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::DeleteRepositoryRequest request = new gcav::DeleteRepositoryRequest
            {
                RepositoryName = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            Operation<Empty, gcav::OperationMetadata> response = await artifactRegistryClient.DeleteRepositoryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcav::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcav::OperationMetadata> retrievedResponse = await artifactRegistryClient.PollOnceDeleteRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRepository</summary>
        public void DeleteRepository()
        {
            // Snippet: DeleteRepository(string, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            Operation<Empty, gcav::OperationMetadata> response = artifactRegistryClient.DeleteRepository(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcav::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcav::OperationMetadata> retrievedResponse = artifactRegistryClient.PollOnceDeleteRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRepositoryAsync</summary>
        public async Task DeleteRepositoryAsync()
        {
            // Snippet: DeleteRepositoryAsync(string, CallSettings)
            // Additional: DeleteRepositoryAsync(string, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            Operation<Empty, gcav::OperationMetadata> response = await artifactRegistryClient.DeleteRepositoryAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcav::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcav::OperationMetadata> retrievedResponse = await artifactRegistryClient.PollOnceDeleteRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRepository</summary>
        public void DeleteRepositoryResourceNames()
        {
            // Snippet: DeleteRepository(RepositoryName, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::RepositoryName name = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            Operation<Empty, gcav::OperationMetadata> response = artifactRegistryClient.DeleteRepository(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcav::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcav::OperationMetadata> retrievedResponse = artifactRegistryClient.PollOnceDeleteRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRepositoryAsync</summary>
        public async Task DeleteRepositoryResourceNamesAsync()
        {
            // Snippet: DeleteRepositoryAsync(RepositoryName, CallSettings)
            // Additional: DeleteRepositoryAsync(RepositoryName, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::RepositoryName name = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            Operation<Empty, gcav::OperationMetadata> response = await artifactRegistryClient.DeleteRepositoryAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcav::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcav::OperationMetadata> retrievedResponse = await artifactRegistryClient.PollOnceDeleteRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListPackages</summary>
        public void ListPackagesRequestObject()
        {
            // Snippet: ListPackages(ListPackagesRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::ListPackagesRequest request = new gcav::ListPackagesRequest
            {
                ParentAsRepositoryName = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedEnumerable<gcav::ListPackagesResponse, gcav::Package> response = artifactRegistryClient.ListPackages(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Package item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListPackagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Package item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Package> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Package item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPackagesAsync</summary>
        public async Task ListPackagesRequestObjectAsync()
        {
            // Snippet: ListPackagesAsync(ListPackagesRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ListPackagesRequest request = new gcav::ListPackagesRequest
            {
                ParentAsRepositoryName = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcav::ListPackagesResponse, gcav::Package> response = artifactRegistryClient.ListPackagesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Package item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListPackagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Package item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Package> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Package item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPackages</summary>
        public void ListPackages()
        {
            // Snippet: ListPackages(string, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedEnumerable<gcav::ListPackagesResponse, gcav::Package> response = artifactRegistryClient.ListPackages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Package item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListPackagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Package item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Package> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Package item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPackagesAsync</summary>
        public async Task ListPackagesAsync()
        {
            // Snippet: ListPackagesAsync(string, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedAsyncEnumerable<gcav::ListPackagesResponse, gcav::Package> response = artifactRegistryClient.ListPackagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Package item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListPackagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Package item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Package> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Package item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPackages</summary>
        public void ListPackagesResourceNames()
        {
            // Snippet: ListPackages(RepositoryName, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::RepositoryName parent = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedEnumerable<gcav::ListPackagesResponse, gcav::Package> response = artifactRegistryClient.ListPackages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Package item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListPackagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Package item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Package> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Package item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPackagesAsync</summary>
        public async Task ListPackagesResourceNamesAsync()
        {
            // Snippet: ListPackagesAsync(RepositoryName, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::RepositoryName parent = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedAsyncEnumerable<gcav::ListPackagesResponse, gcav::Package> response = artifactRegistryClient.ListPackagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Package item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListPackagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Package item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Package> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Package item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetPackage</summary>
        public void GetPackageRequestObject()
        {
            // Snippet: GetPackage(GetPackageRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::GetPackageRequest request = new gcav::GetPackageRequest
            {
                PackageName = gcav::PackageName.FromProjectLocationRepositoryPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PACKAGE]"),
            };
            // Make the request
            gcav::Package response = artifactRegistryClient.GetPackage(request);
            // End snippet
        }

        /// <summary>Snippet for GetPackageAsync</summary>
        public async Task GetPackageRequestObjectAsync()
        {
            // Snippet: GetPackageAsync(GetPackageRequest, CallSettings)
            // Additional: GetPackageAsync(GetPackageRequest, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::GetPackageRequest request = new gcav::GetPackageRequest
            {
                PackageName = gcav::PackageName.FromProjectLocationRepositoryPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PACKAGE]"),
            };
            // Make the request
            gcav::Package response = await artifactRegistryClient.GetPackageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPackage</summary>
        public void GetPackage()
        {
            // Snippet: GetPackage(string, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/packages/[PACKAGE]";
            // Make the request
            gcav::Package response = artifactRegistryClient.GetPackage(name);
            // End snippet
        }

        /// <summary>Snippet for GetPackageAsync</summary>
        public async Task GetPackageAsync()
        {
            // Snippet: GetPackageAsync(string, CallSettings)
            // Additional: GetPackageAsync(string, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/packages/[PACKAGE]";
            // Make the request
            gcav::Package response = await artifactRegistryClient.GetPackageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPackage</summary>
        public void GetPackageResourceNames()
        {
            // Snippet: GetPackage(PackageName, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::PackageName name = gcav::PackageName.FromProjectLocationRepositoryPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PACKAGE]");
            // Make the request
            gcav::Package response = artifactRegistryClient.GetPackage(name);
            // End snippet
        }

        /// <summary>Snippet for GetPackageAsync</summary>
        public async Task GetPackageResourceNamesAsync()
        {
            // Snippet: GetPackageAsync(PackageName, CallSettings)
            // Additional: GetPackageAsync(PackageName, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::PackageName name = gcav::PackageName.FromProjectLocationRepositoryPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PACKAGE]");
            // Make the request
            gcav::Package response = await artifactRegistryClient.GetPackageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePackage</summary>
        public void DeletePackageRequestObject()
        {
            // Snippet: DeletePackage(DeletePackageRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::DeletePackageRequest request = new gcav::DeletePackageRequest
            {
                PackageName = gcav::PackageName.FromProjectLocationRepositoryPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PACKAGE]"),
            };
            // Make the request
            Operation<Empty, gcav::OperationMetadata> response = artifactRegistryClient.DeletePackage(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcav::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcav::OperationMetadata> retrievedResponse = artifactRegistryClient.PollOnceDeletePackage(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePackageAsync</summary>
        public async Task DeletePackageRequestObjectAsync()
        {
            // Snippet: DeletePackageAsync(DeletePackageRequest, CallSettings)
            // Additional: DeletePackageAsync(DeletePackageRequest, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::DeletePackageRequest request = new gcav::DeletePackageRequest
            {
                PackageName = gcav::PackageName.FromProjectLocationRepositoryPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PACKAGE]"),
            };
            // Make the request
            Operation<Empty, gcav::OperationMetadata> response = await artifactRegistryClient.DeletePackageAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcav::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcav::OperationMetadata> retrievedResponse = await artifactRegistryClient.PollOnceDeletePackageAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePackage</summary>
        public void DeletePackage()
        {
            // Snippet: DeletePackage(string, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/packages/[PACKAGE]";
            // Make the request
            Operation<Empty, gcav::OperationMetadata> response = artifactRegistryClient.DeletePackage(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcav::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcav::OperationMetadata> retrievedResponse = artifactRegistryClient.PollOnceDeletePackage(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePackageAsync</summary>
        public async Task DeletePackageAsync()
        {
            // Snippet: DeletePackageAsync(string, CallSettings)
            // Additional: DeletePackageAsync(string, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/packages/[PACKAGE]";
            // Make the request
            Operation<Empty, gcav::OperationMetadata> response = await artifactRegistryClient.DeletePackageAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcav::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcav::OperationMetadata> retrievedResponse = await artifactRegistryClient.PollOnceDeletePackageAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePackage</summary>
        public void DeletePackageResourceNames()
        {
            // Snippet: DeletePackage(PackageName, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::PackageName name = gcav::PackageName.FromProjectLocationRepositoryPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PACKAGE]");
            // Make the request
            Operation<Empty, gcav::OperationMetadata> response = artifactRegistryClient.DeletePackage(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcav::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcav::OperationMetadata> retrievedResponse = artifactRegistryClient.PollOnceDeletePackage(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePackageAsync</summary>
        public async Task DeletePackageResourceNamesAsync()
        {
            // Snippet: DeletePackageAsync(PackageName, CallSettings)
            // Additional: DeletePackageAsync(PackageName, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::PackageName name = gcav::PackageName.FromProjectLocationRepositoryPackage("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PACKAGE]");
            // Make the request
            Operation<Empty, gcav::OperationMetadata> response = await artifactRegistryClient.DeletePackageAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcav::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcav::OperationMetadata> retrievedResponse = await artifactRegistryClient.PollOnceDeletePackageAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListVersions</summary>
        public void ListVersionsRequestObject()
        {
            // Snippet: ListVersions(ListVersionsRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::ListVersionsRequest request = new gcav::ListVersionsRequest
            {
                Parent = "",
                View = gcav::VersionView.Unspecified,
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcav::ListVersionsResponse, gcav::Version> response = artifactRegistryClient.ListVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Version item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Version item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Version> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Version item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVersionsAsync</summary>
        public async Task ListVersionsRequestObjectAsync()
        {
            // Snippet: ListVersionsAsync(ListVersionsRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ListVersionsRequest request = new gcav::ListVersionsRequest
            {
                Parent = "",
                View = gcav::VersionView.Unspecified,
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcav::ListVersionsResponse, gcav::Version> response = artifactRegistryClient.ListVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Version item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Version item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Version> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Version item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVersions</summary>
        public void ListVersions()
        {
            // Snippet: ListVersions(string, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<gcav::ListVersionsResponse, gcav::Version> response = artifactRegistryClient.ListVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Version item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Version item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Version> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Version item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVersionsAsync</summary>
        public async Task ListVersionsAsync()
        {
            // Snippet: ListVersionsAsync(string, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<gcav::ListVersionsResponse, gcav::Version> response = artifactRegistryClient.ListVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Version item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Version item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Version> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Version item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetVersion</summary>
        public void GetVersionRequestObject()
        {
            // Snippet: GetVersion(GetVersionRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::GetVersionRequest request = new gcav::GetVersionRequest
            {
                Name = "",
                View = gcav::VersionView.Unspecified,
            };
            // Make the request
            gcav::Version response = artifactRegistryClient.GetVersion(request);
            // End snippet
        }

        /// <summary>Snippet for GetVersionAsync</summary>
        public async Task GetVersionRequestObjectAsync()
        {
            // Snippet: GetVersionAsync(GetVersionRequest, CallSettings)
            // Additional: GetVersionAsync(GetVersionRequest, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::GetVersionRequest request = new gcav::GetVersionRequest
            {
                Name = "",
                View = gcav::VersionView.Unspecified,
            };
            // Make the request
            gcav::Version response = await artifactRegistryClient.GetVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetVersion</summary>
        public void GetVersion()
        {
            // Snippet: GetVersion(string, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            gcav::Version response = artifactRegistryClient.GetVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetVersionAsync</summary>
        public async Task GetVersionAsync()
        {
            // Snippet: GetVersionAsync(string, CallSettings)
            // Additional: GetVersionAsync(string, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            gcav::Version response = await artifactRegistryClient.GetVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteVersion</summary>
        public void DeleteVersionRequestObject()
        {
            // Snippet: DeleteVersion(DeleteVersionRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::DeleteVersionRequest request = new gcav::DeleteVersionRequest
            {
                Name = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, gcav::OperationMetadata> response = artifactRegistryClient.DeleteVersion(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcav::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcav::OperationMetadata> retrievedResponse = artifactRegistryClient.PollOnceDeleteVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVersionAsync</summary>
        public async Task DeleteVersionRequestObjectAsync()
        {
            // Snippet: DeleteVersionAsync(DeleteVersionRequest, CallSettings)
            // Additional: DeleteVersionAsync(DeleteVersionRequest, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::DeleteVersionRequest request = new gcav::DeleteVersionRequest
            {
                Name = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, gcav::OperationMetadata> response = await artifactRegistryClient.DeleteVersionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcav::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcav::OperationMetadata> retrievedResponse = await artifactRegistryClient.PollOnceDeleteVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVersion</summary>
        public void DeleteVersion()
        {
            // Snippet: DeleteVersion(string, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Empty, gcav::OperationMetadata> response = artifactRegistryClient.DeleteVersion(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcav::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcav::OperationMetadata> retrievedResponse = artifactRegistryClient.PollOnceDeleteVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVersionAsync</summary>
        public async Task DeleteVersionAsync()
        {
            // Snippet: DeleteVersionAsync(string, CallSettings)
            // Additional: DeleteVersionAsync(string, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Empty, gcav::OperationMetadata> response = await artifactRegistryClient.DeleteVersionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcav::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcav::OperationMetadata> retrievedResponse = await artifactRegistryClient.PollOnceDeleteVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListFiles</summary>
        public void ListFilesRequestObject()
        {
            // Snippet: ListFiles(ListFilesRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::ListFilesRequest request = new gcav::ListFilesRequest
            {
                ParentAsRepositoryName = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcav::ListFilesResponse, gcav::File> response = artifactRegistryClient.ListFiles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::File item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListFilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::File item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::File> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::File item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFilesAsync</summary>
        public async Task ListFilesRequestObjectAsync()
        {
            // Snippet: ListFilesAsync(ListFilesRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ListFilesRequest request = new gcav::ListFilesRequest
            {
                ParentAsRepositoryName = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcav::ListFilesResponse, gcav::File> response = artifactRegistryClient.ListFilesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::File item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListFilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::File item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::File> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::File item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFiles</summary>
        public void ListFiles()
        {
            // Snippet: ListFiles(string, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedEnumerable<gcav::ListFilesResponse, gcav::File> response = artifactRegistryClient.ListFiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::File item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListFilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::File item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::File> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::File item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFilesAsync</summary>
        public async Task ListFilesAsync()
        {
            // Snippet: ListFilesAsync(string, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedAsyncEnumerable<gcav::ListFilesResponse, gcav::File> response = artifactRegistryClient.ListFilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::File item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListFilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::File item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::File> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::File item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFiles</summary>
        public void ListFilesResourceNames()
        {
            // Snippet: ListFiles(RepositoryName, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::RepositoryName parent = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedEnumerable<gcav::ListFilesResponse, gcav::File> response = artifactRegistryClient.ListFiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::File item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListFilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::File item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::File> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::File item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFilesAsync</summary>
        public async Task ListFilesResourceNamesAsync()
        {
            // Snippet: ListFilesAsync(RepositoryName, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::RepositoryName parent = gcav::RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedAsyncEnumerable<gcav::ListFilesResponse, gcav::File> response = artifactRegistryClient.ListFilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::File item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListFilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::File item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::File> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::File item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetFile</summary>
        public void GetFileRequestObject()
        {
            // Snippet: GetFile(GetFileRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::GetFileRequest request = new gcav::GetFileRequest
            {
                FileName = gcav::FileName.FromProjectLocationRepositoryFile("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[FILE]"),
            };
            // Make the request
            gcav::File response = artifactRegistryClient.GetFile(request);
            // End snippet
        }

        /// <summary>Snippet for GetFileAsync</summary>
        public async Task GetFileRequestObjectAsync()
        {
            // Snippet: GetFileAsync(GetFileRequest, CallSettings)
            // Additional: GetFileAsync(GetFileRequest, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::GetFileRequest request = new gcav::GetFileRequest
            {
                FileName = gcav::FileName.FromProjectLocationRepositoryFile("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[FILE]"),
            };
            // Make the request
            gcav::File response = await artifactRegistryClient.GetFileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFile</summary>
        public void GetFile()
        {
            // Snippet: GetFile(string, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/files/[FILE]";
            // Make the request
            gcav::File response = artifactRegistryClient.GetFile(name);
            // End snippet
        }

        /// <summary>Snippet for GetFileAsync</summary>
        public async Task GetFileAsync()
        {
            // Snippet: GetFileAsync(string, CallSettings)
            // Additional: GetFileAsync(string, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/files/[FILE]";
            // Make the request
            gcav::File response = await artifactRegistryClient.GetFileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFile</summary>
        public void GetFileResourceNames()
        {
            // Snippet: GetFile(FileName, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::FileName name = gcav::FileName.FromProjectLocationRepositoryFile("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[FILE]");
            // Make the request
            gcav::File response = artifactRegistryClient.GetFile(name);
            // End snippet
        }

        /// <summary>Snippet for GetFileAsync</summary>
        public async Task GetFileResourceNamesAsync()
        {
            // Snippet: GetFileAsync(FileName, CallSettings)
            // Additional: GetFileAsync(FileName, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::FileName name = gcav::FileName.FromProjectLocationRepositoryFile("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[FILE]");
            // Make the request
            gcav::File response = await artifactRegistryClient.GetFileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTags</summary>
        public void ListTagsRequestObject()
        {
            // Snippet: ListTags(ListTagsRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::ListTagsRequest request = new gcav::ListTagsRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcav::ListTagsResponse, gcav::Tag> response = artifactRegistryClient.ListTags(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Tag item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListTagsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Tag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Tag> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Tag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagsAsync</summary>
        public async Task ListTagsRequestObjectAsync()
        {
            // Snippet: ListTagsAsync(ListTagsRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ListTagsRequest request = new gcav::ListTagsRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcav::ListTagsResponse, gcav::Tag> response = artifactRegistryClient.ListTagsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Tag item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListTagsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Tag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Tag> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Tag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTags</summary>
        public void ListTags()
        {
            // Snippet: ListTags(string, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<gcav::ListTagsResponse, gcav::Tag> response = artifactRegistryClient.ListTags(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Tag item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListTagsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Tag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Tag> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Tag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagsAsync</summary>
        public async Task ListTagsAsync()
        {
            // Snippet: ListTagsAsync(string, string, int?, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<gcav::ListTagsResponse, gcav::Tag> response = artifactRegistryClient.ListTagsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Tag item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListTagsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Tag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Tag> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Tag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTag</summary>
        public void GetTagRequestObject()
        {
            // Snippet: GetTag(GetTagRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::GetTagRequest request = new gcav::GetTagRequest { Name = "", };
            // Make the request
            gcav::Tag response = artifactRegistryClient.GetTag(request);
            // End snippet
        }

        /// <summary>Snippet for GetTagAsync</summary>
        public async Task GetTagRequestObjectAsync()
        {
            // Snippet: GetTagAsync(GetTagRequest, CallSettings)
            // Additional: GetTagAsync(GetTagRequest, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::GetTagRequest request = new gcav::GetTagRequest { Name = "", };
            // Make the request
            gcav::Tag response = await artifactRegistryClient.GetTagAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTag</summary>
        public void GetTag()
        {
            // Snippet: GetTag(string, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            gcav::Tag response = artifactRegistryClient.GetTag(name);
            // End snippet
        }

        /// <summary>Snippet for GetTagAsync</summary>
        public async Task GetTagAsync()
        {
            // Snippet: GetTagAsync(string, CallSettings)
            // Additional: GetTagAsync(string, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            gcav::Tag response = await artifactRegistryClient.GetTagAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateTag</summary>
        public void CreateTagRequestObject()
        {
            // Snippet: CreateTag(CreateTagRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::CreateTagRequest request = new gcav::CreateTagRequest
            {
                Parent = "",
                TagId = "",
                Tag = new gcav::Tag(),
            };
            // Make the request
            gcav::Tag response = artifactRegistryClient.CreateTag(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTagAsync</summary>
        public async Task CreateTagRequestObjectAsync()
        {
            // Snippet: CreateTagAsync(CreateTagRequest, CallSettings)
            // Additional: CreateTagAsync(CreateTagRequest, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::CreateTagRequest request = new gcav::CreateTagRequest
            {
                Parent = "",
                TagId = "",
                Tag = new gcav::Tag(),
            };
            // Make the request
            gcav::Tag response = await artifactRegistryClient.CreateTagAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTag</summary>
        public void CreateTag()
        {
            // Snippet: CreateTag(string, Tag, string, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string parent = "";
            gcav::Tag tag = new gcav::Tag();
            string tagId = "";
            // Make the request
            gcav::Tag response = artifactRegistryClient.CreateTag(parent, tag, tagId);
            // End snippet
        }

        /// <summary>Snippet for CreateTagAsync</summary>
        public async Task CreateTagAsync()
        {
            // Snippet: CreateTagAsync(string, Tag, string, CallSettings)
            // Additional: CreateTagAsync(string, Tag, string, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            gcav::Tag tag = new gcav::Tag();
            string tagId = "";
            // Make the request
            gcav::Tag response = await artifactRegistryClient.CreateTagAsync(parent, tag, tagId);
            // End snippet
        }

        /// <summary>Snippet for UpdateTag</summary>
        public void UpdateTagRequestObject()
        {
            // Snippet: UpdateTag(UpdateTagRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::UpdateTagRequest request = new gcav::UpdateTagRequest
            {
                Tag = new gcav::Tag(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcav::Tag response = artifactRegistryClient.UpdateTag(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTagAsync</summary>
        public async Task UpdateTagRequestObjectAsync()
        {
            // Snippet: UpdateTagAsync(UpdateTagRequest, CallSettings)
            // Additional: UpdateTagAsync(UpdateTagRequest, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::UpdateTagRequest request = new gcav::UpdateTagRequest
            {
                Tag = new gcav::Tag(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcav::Tag response = await artifactRegistryClient.UpdateTagAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTag</summary>
        public void UpdateTag()
        {
            // Snippet: UpdateTag(Tag, FieldMask, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::Tag tag = new gcav::Tag();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcav::Tag response = artifactRegistryClient.UpdateTag(tag, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTagAsync</summary>
        public async Task UpdateTagAsync()
        {
            // Snippet: UpdateTagAsync(Tag, FieldMask, CallSettings)
            // Additional: UpdateTagAsync(Tag, FieldMask, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::Tag tag = new gcav::Tag();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcav::Tag response = await artifactRegistryClient.UpdateTagAsync(tag, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteTag</summary>
        public void DeleteTagRequestObject()
        {
            // Snippet: DeleteTag(DeleteTagRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::DeleteTagRequest request = new gcav::DeleteTagRequest { Name = "", };
            // Make the request
            artifactRegistryClient.DeleteTag(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTagAsync</summary>
        public async Task DeleteTagRequestObjectAsync()
        {
            // Snippet: DeleteTagAsync(DeleteTagRequest, CallSettings)
            // Additional: DeleteTagAsync(DeleteTagRequest, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::DeleteTagRequest request = new gcav::DeleteTagRequest { Name = "", };
            // Make the request
            await artifactRegistryClient.DeleteTagAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTag</summary>
        public void DeleteTag()
        {
            // Snippet: DeleteTag(string, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            artifactRegistryClient.DeleteTag(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTagAsync</summary>
        public async Task DeleteTagAsync()
        {
            // Snippet: DeleteTagAsync(string, CallSettings)
            // Additional: DeleteTagAsync(string, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            await artifactRegistryClient.DeleteTagAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = artifactRegistryClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await artifactRegistryClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = artifactRegistryClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await artifactRegistryClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = artifactRegistryClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await artifactRegistryClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProjectSettings</summary>
        public void GetProjectSettingsRequestObject()
        {
            // Snippet: GetProjectSettings(GetProjectSettingsRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::GetProjectSettingsRequest request = new gcav::GetProjectSettingsRequest
            {
                ProjectSettingsName = gcav::ProjectSettingsName.FromProject("[PROJECT]"),
            };
            // Make the request
            gcav::ProjectSettings response = artifactRegistryClient.GetProjectSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetProjectSettingsAsync</summary>
        public async Task GetProjectSettingsRequestObjectAsync()
        {
            // Snippet: GetProjectSettingsAsync(GetProjectSettingsRequest, CallSettings)
            // Additional: GetProjectSettingsAsync(GetProjectSettingsRequest, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::GetProjectSettingsRequest request = new gcav::GetProjectSettingsRequest
            {
                ProjectSettingsName = gcav::ProjectSettingsName.FromProject("[PROJECT]"),
            };
            // Make the request
            gcav::ProjectSettings response = await artifactRegistryClient.GetProjectSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProjectSettings</summary>
        public void GetProjectSettings()
        {
            // Snippet: GetProjectSettings(string, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/projectSettings";
            // Make the request
            gcav::ProjectSettings response = artifactRegistryClient.GetProjectSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetProjectSettingsAsync</summary>
        public async Task GetProjectSettingsAsync()
        {
            // Snippet: GetProjectSettingsAsync(string, CallSettings)
            // Additional: GetProjectSettingsAsync(string, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/projectSettings";
            // Make the request
            gcav::ProjectSettings response = await artifactRegistryClient.GetProjectSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProjectSettings</summary>
        public void GetProjectSettingsResourceNames()
        {
            // Snippet: GetProjectSettings(ProjectSettingsName, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::ProjectSettingsName name = gcav::ProjectSettingsName.FromProject("[PROJECT]");
            // Make the request
            gcav::ProjectSettings response = artifactRegistryClient.GetProjectSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetProjectSettingsAsync</summary>
        public async Task GetProjectSettingsResourceNamesAsync()
        {
            // Snippet: GetProjectSettingsAsync(ProjectSettingsName, CallSettings)
            // Additional: GetProjectSettingsAsync(ProjectSettingsName, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ProjectSettingsName name = gcav::ProjectSettingsName.FromProject("[PROJECT]");
            // Make the request
            gcav::ProjectSettings response = await artifactRegistryClient.GetProjectSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateProjectSettings</summary>
        public void UpdateProjectSettingsRequestObject()
        {
            // Snippet: UpdateProjectSettings(UpdateProjectSettingsRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::UpdateProjectSettingsRequest request = new gcav::UpdateProjectSettingsRequest
            {
                ProjectSettings = new gcav::ProjectSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcav::ProjectSettings response = artifactRegistryClient.UpdateProjectSettings(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProjectSettingsAsync</summary>
        public async Task UpdateProjectSettingsRequestObjectAsync()
        {
            // Snippet: UpdateProjectSettingsAsync(UpdateProjectSettingsRequest, CallSettings)
            // Additional: UpdateProjectSettingsAsync(UpdateProjectSettingsRequest, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::UpdateProjectSettingsRequest request = new gcav::UpdateProjectSettingsRequest
            {
                ProjectSettings = new gcav::ProjectSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcav::ProjectSettings response = await artifactRegistryClient.UpdateProjectSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProjectSettings</summary>
        public void UpdateProjectSettings()
        {
            // Snippet: UpdateProjectSettings(ProjectSettings, FieldMask, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::ProjectSettings projectSettings = new gcav::ProjectSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcav::ProjectSettings response = artifactRegistryClient.UpdateProjectSettings(projectSettings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateProjectSettingsAsync</summary>
        public async Task UpdateProjectSettingsAsync()
        {
            // Snippet: UpdateProjectSettingsAsync(ProjectSettings, FieldMask, CallSettings)
            // Additional: UpdateProjectSettingsAsync(ProjectSettings, FieldMask, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ProjectSettings projectSettings = new gcav::ProjectSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcav::ProjectSettings response = await artifactRegistryClient.UpdateProjectSettingsAsync(projectSettings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetVPCSCConfig</summary>
        public void GetVPCSCConfigRequestObject()
        {
            // Snippet: GetVPCSCConfig(GetVPCSCConfigRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::GetVPCSCConfigRequest request = new gcav::GetVPCSCConfigRequest
            {
                VpcscConfigName = gcav::VpcscConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            gcav::VPCSCConfig response = artifactRegistryClient.GetVPCSCConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetVPCSCConfigAsync</summary>
        public async Task GetVPCSCConfigRequestObjectAsync()
        {
            // Snippet: GetVPCSCConfigAsync(GetVPCSCConfigRequest, CallSettings)
            // Additional: GetVPCSCConfigAsync(GetVPCSCConfigRequest, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::GetVPCSCConfigRequest request = new gcav::GetVPCSCConfigRequest
            {
                VpcscConfigName = gcav::VpcscConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            gcav::VPCSCConfig response = await artifactRegistryClient.GetVPCSCConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetVPCSCConfig</summary>
        public void GetVPCSCConfig()
        {
            // Snippet: GetVPCSCConfig(string, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/vpcscConfig";
            // Make the request
            gcav::VPCSCConfig response = artifactRegistryClient.GetVPCSCConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetVPCSCConfigAsync</summary>
        public async Task GetVPCSCConfigAsync()
        {
            // Snippet: GetVPCSCConfigAsync(string, CallSettings)
            // Additional: GetVPCSCConfigAsync(string, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/vpcscConfig";
            // Make the request
            gcav::VPCSCConfig response = await artifactRegistryClient.GetVPCSCConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetVPCSCConfig</summary>
        public void GetVPCSCConfigResourceNames()
        {
            // Snippet: GetVPCSCConfig(VpcscConfigName, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::VpcscConfigName name = gcav::VpcscConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            gcav::VPCSCConfig response = artifactRegistryClient.GetVPCSCConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetVPCSCConfigAsync</summary>
        public async Task GetVPCSCConfigResourceNamesAsync()
        {
            // Snippet: GetVPCSCConfigAsync(VpcscConfigName, CallSettings)
            // Additional: GetVPCSCConfigAsync(VpcscConfigName, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::VpcscConfigName name = gcav::VpcscConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            gcav::VPCSCConfig response = await artifactRegistryClient.GetVPCSCConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateVPCSCConfig</summary>
        public void UpdateVPCSCConfigRequestObject()
        {
            // Snippet: UpdateVPCSCConfig(UpdateVPCSCConfigRequest, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::UpdateVPCSCConfigRequest request = new gcav::UpdateVPCSCConfigRequest
            {
                VpcscConfig = new gcav::VPCSCConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcav::VPCSCConfig response = artifactRegistryClient.UpdateVPCSCConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateVPCSCConfigAsync</summary>
        public async Task UpdateVPCSCConfigRequestObjectAsync()
        {
            // Snippet: UpdateVPCSCConfigAsync(UpdateVPCSCConfigRequest, CallSettings)
            // Additional: UpdateVPCSCConfigAsync(UpdateVPCSCConfigRequest, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::UpdateVPCSCConfigRequest request = new gcav::UpdateVPCSCConfigRequest
            {
                VpcscConfig = new gcav::VPCSCConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcav::VPCSCConfig response = await artifactRegistryClient.UpdateVPCSCConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateVPCSCConfig</summary>
        public void UpdateVPCSCConfig()
        {
            // Snippet: UpdateVPCSCConfig(VPCSCConfig, FieldMask, CallSettings)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = gcav::ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            gcav::VPCSCConfig vpcscConfig = new gcav::VPCSCConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcav::VPCSCConfig response = artifactRegistryClient.UpdateVPCSCConfig(vpcscConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateVPCSCConfigAsync</summary>
        public async Task UpdateVPCSCConfigAsync()
        {
            // Snippet: UpdateVPCSCConfigAsync(VPCSCConfig, FieldMask, CallSettings)
            // Additional: UpdateVPCSCConfigAsync(VPCSCConfig, FieldMask, CancellationToken)
            // Create client
            gcav::ArtifactRegistryClient artifactRegistryClient = await gcav::ArtifactRegistryClient.CreateAsync();
            // Initialize request argument(s)
            gcav::VPCSCConfig vpcscConfig = new gcav::VPCSCConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcav::VPCSCConfig response = await artifactRegistryClient.UpdateVPCSCConfigAsync(vpcscConfig, updateMask);
            // End snippet
        }
    }
}
