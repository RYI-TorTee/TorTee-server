using Microsoft.Extensions.Configuration;
using TorTee.BLL.Services.IServices;
using Azure.Storage.Blobs;
using TorTee.Core.Settings;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using TorTee.BLL.Models;

namespace TorTee.BLL.Services
{
    public class FileStorageService : IFileStorageService
    {
        private readonly BlobServiceClient _blobServiceClient;
        private readonly IConfiguration _configuration;
        private readonly AzureBlobSettings _azureBlobSettings;
        private readonly BlobContainerClient _blobContainerClient;

        public FileStorageService(IConfiguration configuration)
        {
            _configuration = configuration;
            _azureBlobSettings = _configuration.GetSection(nameof(AzureBlobSettings)).Get<AzureBlobSettings>() ?? throw new Exception("AzureBlobSettings is invalid");
            _blobServiceClient = new BlobServiceClient(_azureBlobSettings.BlobServiceClient);
            _blobContainerClient = GetContainerClient(_azureBlobSettings.BlobContainerName);
        }

        public async Task<string> UploadFileBlobAsync(IFormFile file)
        {
            string fileName = file.FileName;
            using (var memoryStream = new MemoryStream())
            {
                file.CopyTo(memoryStream);
                memoryStream.Position = 0;
                var client = await _blobContainerClient.UploadBlobAsync(fileName, memoryStream, default);                
              
            }
            var blobClient = _blobContainerClient.GetBlobClient(fileName);
            return blobClient.Uri.AbsoluteUri;
        }

        public async Task<IEnumerable<string>> UploadFilesBlobAsync(List<IFormFile> files)
        {
            var uriResponse = new List<string>();
            foreach (var file in files)
            {
                string fileName = file.FileName;
                using (var memoryStream = new MemoryStream())
                {
                    file.CopyTo(memoryStream);
                    memoryStream.Position = 0;
                    var client = await _blobContainerClient.UploadBlobAsync(fileName, memoryStream, default);                   
                }
                var blobClient = _blobContainerClient.GetBlobClient(fileName);
                uriResponse.Add(blobClient.Uri.AbsoluteUri);
            };

            return uriResponse;
        }

        private BlobContainerClient GetContainerClient(string blobContainerName)
        {
            var containerClient = _blobServiceClient.GetBlobContainerClient(blobContainerName);
            containerClient.CreateIfNotExists(PublicAccessType.Blob);
            return containerClient;
        }
    }
}
