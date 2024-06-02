using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;
using TorTee.BLL.Services.IServices;

namespace TorTee.API.Controllers
{
    public class FileController : ControllerBase
    {
        private readonly IFileStorageService _fileStorageService;

        public FileController(IFileStorageService fileStorageService)
        {
            _fileStorageService = fileStorageService;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile([FromForm] IFormFile file)
        {
            var url = await _fileStorageService.UploadFileBlobAsync(file);
            return Ok(url); 
        }
        [HttpPost("upload/test")]
        public async Task<IActionResult> UploadFileTest([FromForm] IFormFile file)
        {
            var url = await _fileStorageService.UploadFileBlobAsync(file);
            return Ok(url);
        }
    }
}
