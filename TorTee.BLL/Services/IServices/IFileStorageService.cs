using Microsoft.AspNetCore.Http;

namespace TorTee.BLL.Services.IServices
{
    public interface IFileStorageService
    {
        Task<IEnumerable<string>> UploadFilesBlobAsync(List<IFormFile> files);
        Task<string> UploadFileBlobAsync(IFormFile file);
    }
}
