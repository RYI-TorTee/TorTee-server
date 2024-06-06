using Microsoft.AspNetCore.Http;

namespace TorTee.BLL.Models.Requests.Assignments
{
    public class CreateAssignmentRequest
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public IFormFile? File { get; set; }        
        public DateTime Deadline { get; set; }
        public Guid MenteeId { get; set; }

    }
}
