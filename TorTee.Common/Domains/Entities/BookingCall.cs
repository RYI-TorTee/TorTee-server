using TorTee.Core.Domains.Entities.BaseEntities;
using TorTee.Core.Domains.Enums;

namespace TorTee.Core.Domains.Entities
{
    public class BookingCall : EntityBase<Guid>
    {
        public DateTime BookingTime { get; set; }
        public DateTime TimeStart { get; set; }
        public string? Description { get; set; }
        public BookingCallStatus Status { get; set; } = BookingCallStatus.PENDING;

        public Guid MenteeId { get; set; }
        public User Mentee { get; set; } = null!;

        public Guid SessionId { get; set; }
        public Session Session { get; set; } = null!;
    }
}
