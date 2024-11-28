// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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

using System;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Storage.V1.IntegrationTests;
[Collection(nameof(StorageFixture))]
public class GetBucketTest
{
    private readonly StorageFixture _fixture;

    public GetBucketTest(StorageFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public async Task GetBucketGeneration()
    {
        // We get bucket object using get bucket async method for bucket which is not soft deleted yet. 
        var bucket = await _fixture.Client.GetBucketAsync(_fixture.SoftDeleteBucketOne, new GetBucketOptions { SoftDeleted = false });
        try
        {
            await _fixture.Client.DeleteBucketAsync(_fixture.SoftDeleteBucketOne);
        }
        catch (Exception)
        {
            // If bucket is not empty, we delete on a best effort basis.
            foreach (var storageObject in _fixture.Client.ListObjects(_fixture.SoftDeleteBucketOne, ""))
            {
               await _fixture.Client.DeleteObjectAsync(_fixture.SoftDeleteBucketOne, storageObject.Name);
            }
            await _fixture.Client.DeleteBucketAsync(_fixture.SoftDeleteBucketOne);
        }
        // We get softDeleted object using get bucket async method for soft deleted bucket. 
        var softDeleted = await _fixture.Client.GetBucketAsync(_fixture.SoftDeleteBucketOne, new GetBucketOptions { SoftDeleted = true, Generation = bucket.Generation });
        Assert.NotNull(bucket.Generation);
        Assert.NotNull(softDeleted.Generation);
    }

    [Fact]
    public async Task GetSoftDeletedBucket()
    {
        // We get bucket object using get bucket async method for soft delete bucket before deleting it. 
        var bucket = await _fixture.Client.GetBucketAsync(_fixture.SoftDeleteBucketTwo, new GetBucketOptions { SoftDeleted = false });
        try
        {
            await _fixture.Client.DeleteBucketAsync(_fixture.SoftDeleteBucketTwo);
        }
        catch (Exception)
        {
            // If bucket is not empty, we delete on a best effort basis.
            foreach (var storageObject in _fixture.Client.ListObjects(_fixture.SoftDeleteBucketTwo, ""))
            {
                await _fixture.Client.DeleteObjectAsync(_fixture.SoftDeleteBucketTwo, storageObject.Name);
            }
            await _fixture.Client.DeleteBucketAsync(_fixture.SoftDeleteBucketTwo);
        }

        // And now we get softDeleted object using get bucket async method after deleting soft delete bucket.
        var softDeleted = await _fixture.Client.GetBucketAsync(_fixture.SoftDeleteBucketTwo, new GetBucketOptions { SoftDeleted = true, Generation = bucket.Generation });
        Assert.NotNull(bucket.Generation);
        Assert.NotNull(softDeleted.Generation);
        Assert.NotNull(bucket.Name);
        Assert.NotNull(softDeleted.Name);
        Assert.Equal(bucket.Name, softDeleted.Name);
        Assert.Equal(bucket.Generation, softDeleted.Generation);
        Assert.NotNull(softDeleted.SoftDeleteTimeDateTimeOffset);
        Assert.NotNull(softDeleted.HardDeleteTimeDateTimeOffset);
    }
}
