using TorTee.Core.Domains.Entities.BaseEntities;

namespace TorTee.Core.Domains.Entities
{
    public class Message : EntityBase<Guid>
    {
        public string Content { get; set; } = null!;
        public DateTime SentTime { get; set; } = DateTime.UtcNow;
        public DateTime? DateRead { get; set; }

        public Guid SenderId { get; set; }
        public User Sender { get; set; } = null!;

        public Guid ReceiverId { get; set; }
        public User Receiver { get; set; } = null!;
    }
}
