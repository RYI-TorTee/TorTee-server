using TorTee.BLL.Models.Responses.AssignmentSubmissions;

namespace TorTee.BLL.Models.Responses.Assignments
{
    public class AssignmentDetailResponse
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? File { get; set; }
        public DateTime AssignedDate { get; set; }
        public DateTime Deadline { get; set; }
        public AssignmentUserResponse? Mentor { get; set; }
        public AssignmentUserResponse? Mentee { get; set; }
        public Guid MentorId { get; set; }
        public Guid MenteeId { get; set; }
        public ICollection<AssignmentSubmissionResponse>? Submissions { get; set; }
    }
   
}