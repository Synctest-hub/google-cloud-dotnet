﻿// Copyright 2022 Google LLC
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

using Google.Cloud.Tools.Common;
using System;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager
{
    public sealed class PatchVersionCommand : CommandBase
    {
        public PatchVersionCommand()
            : base("patch-version", "Patch a version in apis.json and generate project files", "id")
        {
        }

        protected override void ExecuteImpl(string[] args)
        {
            string id = args[0];

            // It's slightly inefficient that we load the API catalog once here and once later on, and the code duplication
            // is annoying too, but it's insignficant really - and at least the code is simple.
            var catalog = ApiCatalog.Load();
            var api = catalog[id];

            var apisToIncrement = new[] { api };
            if (api.PackageGroup is PackageGroup group)
            {
                Console.WriteLine($"API '{id}' is in package group '{group.Id}'. Patching all APIs.");
                apisToIncrement = group.PackageIds.Select(x => catalog[x]).ToArray();
            }

            foreach (var apiToIncrement in apisToIncrement)
            {
                var version = apiToIncrement.StructuredVersion.AfterPatch().ToString();
                new SetVersionCommand().InternalExecute(apiToIncrement.Id, version, quiet: false);
            }
        }
    }
}
