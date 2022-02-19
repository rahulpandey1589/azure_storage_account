using Azure.Storage.Blobs;
using System;
using System.IO;
using System.Threading.Tasks;

namespace azure_storage.core.BlobStorage
{
    public class BlobOperations
    {

        private string connectionString
             = Environment.GetEnvironmentVariable("AZURE_STORAGE_CONNECTION_STRING");

        public async Task CreateBlobContainerAsync(
            string containerName)
        {
            try
            {
                var blobServiceClient = CreateBlobServiceClient();

                var data =
                    await blobServiceClient.CreateBlobContainerAsync(containerName).ConfigureAwait(false);
            }
            catch (Exception) { }
        }

        public async Task UploadBlobAsync(
            string containerName,
            string rootFolderName,
            string fileName)
        {
            var blobContainerClient =
                CreateBlobContainerClient(CreateBlobServiceClient(), containerName);

            var completePath =
                  $"{ rootFolderName }//{ Path.GetFileNameWithoutExtension(fileName)}" +
                   $"{Guid.NewGuid().ToString()}{Path.GetExtension(fileName)}";

            var blobClient = blobContainerClient.GetBlobClient(completePath);

            var localPath = "E:\\" + fileName;

            await blobClient.UploadAsync(localPath);
        }


        private BlobServiceClient CreateBlobServiceClient()
        {
            return new BlobServiceClient(connectionString);
        }

        private BlobContainerClient CreateBlobContainerClient(
            BlobServiceClient blobServiceClient,
            string containerName)
        {
            return blobServiceClient.GetBlobContainerClient(containerName);
        }
    }
}
