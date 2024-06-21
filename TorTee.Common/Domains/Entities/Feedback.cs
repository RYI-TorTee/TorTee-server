using TorTee.Core.Domains.Entities.BaseEntities;

namespace TorTee.Core.Domains.Entities
{
    public class Feedback : EntityBase<Guid>
    {
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public string? Reply { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public Guid MenteeApplicationId { get; set; }
        public MenteeApplication MenteeApplication { get; set; } = null!;
    }
}
