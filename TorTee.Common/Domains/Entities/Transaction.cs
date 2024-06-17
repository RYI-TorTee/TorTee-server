using TorTee.Core.Domains.Entities.BaseEntities;

namespace TorTee.Core.Domains.Entities
{
    public class Transaction : EntityBase<Guid>
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public double Total { get; set; }
        public Guid MenteeApplicationId { get; set; }
        public MenteeApplication MenteeApplication { get; set; } = null!;
    }
}
