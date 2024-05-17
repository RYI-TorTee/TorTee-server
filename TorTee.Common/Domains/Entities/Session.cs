using TorTee.Core.Domains.Entities.BaseEntities;

namespace TorTee.Core.Domains.Entities
{
    public class Session : EntityBase<Guid>
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Duration { get; set; }
        public double Price { get; set; }

        public Guid MentorId { get; set; }
        public User Mentor { get; set; } = null!;

        public ICollection<BookingCall>? BookingCalls { get; set; }
    }
}
