using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Domains.Enums;

namespace TorTee.Core.Dtos
{
    public class BookingCallDTO
    {
        public Guid Id { get; set; }
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
