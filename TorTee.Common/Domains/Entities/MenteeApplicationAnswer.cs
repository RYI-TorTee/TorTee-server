using TorTee.Core.Domains.Entities.BaseEntities;

namespace TorTee.Core.Domains.Entities
{
    public class MenteeApplicationAnswer: EntityBase<Guid>
    {
        public string? ResponseContent { get; set; }

        public Guid QuestionId { get; set; }
        public ApplicationQuestion Question { get; set; } = null!;
        public Guid MenteeApplicationId { get; set; }
        public MenteeApplication MenteeApplication { get; set; } = null!;
    }
}
