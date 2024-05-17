using TorTee.Core.Domains.Entities.BaseEntities;

namespace TorTee.Core.Domains.Entities
{
    public class Feedback: EntityBase<Guid>
    {
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime CreatedDate { get; set; }

        public Guid MentorshipId { get; set; }
        public Mentorship Mentorship { get; set; } = null!;

    }
}
