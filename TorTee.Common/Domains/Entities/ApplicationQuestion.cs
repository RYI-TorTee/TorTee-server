using TorTee.Core.Domains.Entities.BaseEntities;

namespace TorTee.Core.Domains.Entities
{
    public class ApplicationQuestion : EntityBase<Guid>
    {
        public string Content { get; set; } = null!;
        public ICollection<MenteeApplicationAnswer>? Answers { get; set; }
    }
}
