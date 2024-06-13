using TorTee.Core.Domains.Enums;

namespace TorTee.BLL.Models.Responses.AssignmentSubmissions
{
    public class AssignmentSubmissionResponse
    {
        public Guid Id { get; set; }
        public string? File { get; set; }
        public string? Description { get; set; }
        public float Grade { get; set; }
        public DateTime SubmitedDate { get; set; } 
        public string? Status { get; set; } 
        public Guid AssignmentId { get; set; }       
    }
}
