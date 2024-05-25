using TorTee.Core.Domains.Entities.BaseEntities;
using TorTee.Core.Domains.Enums;

namespace TorTee.Core.Domains.Entities
{
    public class Message : EntityBase<Guid>
    {
        public string Content { get; set; } = null!;
        public DateTime SentTime { get; set; } = DateTime.UtcNow;
        public MessageStatus Status { get; set; } = MessageStatus.UNSEEN;

        public Guid SenderId { get; set; }
        public User Sender { get; set; } = null!;

        public Guid ReceiverId { get; set; }
        public User Receiver { get; set; } = null!;
    }
}
