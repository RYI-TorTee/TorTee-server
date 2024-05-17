using TorTee.Core.Domains.Entities.BaseEntities;

namespace TorTee.Core.Domains.Entities
{
    public class Feedback: EntityBase<Guid>
    {
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime CreatedDate { get; set; }

        public Guid MentorId { get; set; }
        public User Mentor { get; set; } = null!;

        public Guid MenteeId { get; set; }
        public User Mentee { get; set; } = null!;

    }
}
