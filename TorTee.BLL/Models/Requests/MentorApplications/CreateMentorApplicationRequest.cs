using Microsoft.AspNetCore.Http;

namespace TorTee.BLL.Models.Requests.MentorApplications
{
    public class CreateMentorApplicationRequest
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Category { get; set; } = null!;
        public IFormFile CV { get; set; } = null!;
        public string? Company { get; set; }
        public string? JobTille { get; set; }
        public string Bio { get; set; } = null!;
        public string Reason { get; set; } = null!;
        public string Achievement { get; set; } = null!;
    }
}
