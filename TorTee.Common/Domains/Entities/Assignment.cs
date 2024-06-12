using TorTee.Core.Domains.Entities.BaseEntities;

namespace TorTee.Core.Domains.Entities
{
    public class Assignment : EntityBase<Guid>
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? File { get; set; }
        public DateTime AssignedDate { get; set; } = DateTime.Now;
        public DateTime Deadline { get; set; }        

        public Guid MentorId { get; set; }
        public User Mentor { get; set; } = null!;
        public Guid MenteeId { get; set; }
        public User Mentee { get; set; } = null!;
        public ICollection<AssignmentSubmission>? Submissions { get; set; }
    }
}
