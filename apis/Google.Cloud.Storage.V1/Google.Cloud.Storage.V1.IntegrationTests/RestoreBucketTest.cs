using System;
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
            var bucket = await _fixture.Client.GetBucketAsync(_fixture.SoftDeleteBucketThree, new GetBucketOptions { SoftDeleted = false });
            // We delete soft delete bucket.
            try
            {
                await _fixture.Client.DeleteBucketAsync(_fixture.SoftDeleteBucketThree);
            }
            catch (Exception)
            {
                // If bucket is not empty, we delete on a best effort basis.
                foreach (var storageObject in _fixture.Client.ListObjects(_fixture.SoftDeleteBucketThree, ""))
                {
                    await _fixture.Client.DeleteObjectAsync(_fixture.SoftDeleteBucketThree, storageObject.Name);
                }
                await _fixture.Client.DeleteBucketAsync(_fixture.SoftDeleteBucketThree);
            }

            // And now we can restore bucket using generation id.
            var restored = await _fixture.Client.RestoreBucketAsync(_fixture.SoftDeleteBucketThree, bucket.Generation.Value);
            Assert.Equal(_fixture.SoftDeleteBucketThree, restored.Name);
            Assert.Equal(bucket.Generation, restored.Generation);
        }
    }
}
