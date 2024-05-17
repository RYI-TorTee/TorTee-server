using TorTee.Core.Domains.Entities.BaseEntities;
using TorTee.Core.Domains.Enums;

namespace TorTee.Core.Domains.Entities
{
    public class MentorApplication: EntityBase<Guid>
    {
        public DateTime AppliedDate { get; set; }
        public string CV { get; set; } = null!;
        public string? Description { get; set; }
        public ApplicationStatus Status { get; set; } = ApplicationStatus.PENDING;

        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
