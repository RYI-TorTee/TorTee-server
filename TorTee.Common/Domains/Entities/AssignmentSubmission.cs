using TorTee.Core.Domains.Entities.BaseEntities;
using TorTee.Core.Domains.Enums;

namespace TorTee.Core.Domains.Entities
{
    public class AssignmentSubmission : EntityBase<Guid>
    {
        public string? File { get; set; }
        public string? Description { get; set; }
        public string? CommentOfMentor { get; set; }
        public float? Grade { get; set; }
        public DateTime SubmitedDate { get; set; } = DateTime.Now;
        public SubmissionStatus Status { get; set; } = SubmissionStatus.UNGRADED;

        public Guid AssignmentId { get; set; }
        public Assignment Assignment { get; set; } = null!;
    }
}
