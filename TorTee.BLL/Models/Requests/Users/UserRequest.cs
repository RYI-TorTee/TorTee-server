using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace TorTee.BLL.Models.Requests.Users
{
    public class UserRequest
    {
        [MaxLength(100)]
        [MinLength(10)]
        public string FullName { get; set; } = null!;
        public IFormFile? ProfilePic { get; set; }
        [Phone]
        public string? PhoneNumber { get; set; }
        public string? Bio { get; set; }
        public string? Company { get; set; }
        public string? JobTitle { get; set; }
    }
}
