using TorTee.BLL.Models.Responses.Users;

namespace TorTee.BLL.Models.Responses.Assignments
{
    public class AssignmentResponse
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? File { get; set; }
        public DateTime AssignedDate { get; set; }
        public DateTime Deadline { get; set; }
        public UserResponse? Mentor { get; set; }       
        public UserResponse? Mentee { get; set; }       
        public Guid MentorId { get; set; }       
        public Guid MenteeId { get; set; }   
        public bool IsSubmited { get; set; }   
        public bool ÍsGraded { get; set; }   
    }
}
