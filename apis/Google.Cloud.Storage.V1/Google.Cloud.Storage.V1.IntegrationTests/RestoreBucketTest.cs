using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    [Collection(nameof(StorageFixture))]
    public class RestoreBucketTest
    {
        private readonly StorageFixture _fixture;

        public RestoreBucketTest(StorageFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public async Task RestoreSoftDeletedBucket()
        {

            // We get bucket object using get bucket async method for soft delete bucket before deleting it. 
            var bucket = await _fixture.Client.GetBucketAsync(_fixture.SoftDeleteBucket, new GetBucketOptions { SoftDeleted = false });
            // We delete soft delete bucket.
            await _fixture.Client.DeleteBucketAsync(_fixture.SoftDeleteBucket);

            // And now we can restore bucket using generation id.
            var restored = await _fixture.Client.RestoreBucketAsync(_fixture.SoftDeleteBucket, bucket.Generation.Value);
            Assert.Equal(_fixture.SoftDeleteBucket, restored.Name);
            Assert.Equal(bucket.Generation, restored.Generation);
        }
    }
}
