using TorTee.Core.Domains.Entities.BaseEntities;

namespace TorTee.Core.Domains.Entities
{
    public class Mentorship : EntityBase<Guid>
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Guid MentorId { get; set; }
        public User Mentor { get; set; } = null!;

        public Guid MenteeId { get; set; }
        public User Mentee { get; set; } = null!;
    }
}
