﻿// Copyright 2018 Google LLC
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

using Google.Cloud.Spanner.Data.CommonTesting;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [CollectionDefinition(nameof(ChunkingTableFixture))]
    public class ChunkingTableFixture : SpannerTableFixture, ICollectionFixture<ChunkingTableFixture>
    {
        public ChunkingTableFixture() : base("ChunkingTable")
        {
        }

        protected override void CreateTable()
        {
            ExecuteDdl($@"CREATE TABLE {TableName} (
                        K                   STRING(MAX) NOT NULL,
                        StringValue         STRING(MAX),
                        BytesValue          BYTES(MAX),
                        StringArrayValue    ARRAY<STRING(MAX)>,
                        BytesArrayValue     ARRAY<BYTES(MAX)>,
                        ) PRIMARY KEY (K)");
        }
    }
}
