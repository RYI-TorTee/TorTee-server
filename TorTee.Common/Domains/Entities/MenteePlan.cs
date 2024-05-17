using TorTee.Core.Domains.Entities.BaseEntities;
using TorTee.Core.Domains.Enums;

namespace TorTee.Core.Domains.Entities
{
    public class MenteePlan: EntityBase<Guid>
    {
        public string?  Name { get; set; }
        public string?  Description { get; set; }
        public int TotalSlot { get; set; }
        public double Price { get; set; }
        public MenteePlanStatus Status { get; set; } = MenteePlanStatus.AVAILABLE;

        public Guid MentorId { get; set; }
        public User Mentor { get; set; } = null!;

        public ICollection<MenteeApplication>? MenteeApplications { get; set; }
    }
}
