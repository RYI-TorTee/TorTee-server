using TorTee.Core.Domains.Entities.BaseEntities;
using TorTee.Core.Domains.Enums;

namespace TorTee.Core.Domains.Entities
{
    public class MenteeApplication: EntityBase<Guid>
    {
        public DateTime AppliedDate { get; set; } = DateTime.Now;
        public ApplicationStatus Status { get; set; } = ApplicationStatus.PENDING;

        public double Price { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Guid UserId { get; set; }
        public User? User { get; set; }

        public Guid MenteePlanId { get; set; }
        public MenteePlan MenteePlan { get; set; } = null!;

        public Guid TransactionId { get; set; }
        public Transaction? Transaction { get; set; }
        public Guid? FeedbackId { get; set; }
        public Feedback? Feedback { get; set; }
        public int OrderCode { get; set; }

        public ICollection<MenteeApplicationAnswer>? MenteeApplicationAnswers { get; set; }
    }
}
