using TorTee.Core.Domains.Entities.BaseEntities;
using TorTee.Core.Domains.Enums;

namespace TorTee.Core.Domains.Entities
{
    public class MenteeApplication: EntityBase<Guid>
    {
        public DateTime AppliedDate { get; set; } = DateTime.Now;
        public ApplicationStatus Status { get; set; } = ApplicationStatus.PENDING;
        public Guid UserId { get; set; }
        public User? User { get; set; }

        public Guid MenteePlanId { get; set; }
        public MenteePlan MenteePlan { get; set; } = null!;

        public ICollection<MenteeApplicationAnswer>? MenteeApplicationAnswers { get; set; }
    }
}
