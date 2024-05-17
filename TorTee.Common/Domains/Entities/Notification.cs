using TorTee.Core.Domains.Entities.BaseEntities;
using TorTee.Core.Domains.Enums;

namespace TorTee.Core.Domains.Entities
{
    public class Notification : EntityBase<Guid>
    {
        public string Content { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public MessageStatus Status { get; set; } = MessageStatus.UNSEEN;

        public Guid SenderId { get; set; }
        public User? Sender { get; set; }

        public Guid ReceiverId { get; set; }
        public User Receiver { get; set; } = null!;
    }
}
