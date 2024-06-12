using Microsoft.AspNetCore.Http;

namespace TorTee.BLL.Models.Requests.Submissions
{
    public class CreateSubmissionRequest
    {
        public IFormFile? File { get; set; }    
        public DateTime SubmitedDate { get; set; }
        public Guid AssignmentId { get; set; }
    }
}
