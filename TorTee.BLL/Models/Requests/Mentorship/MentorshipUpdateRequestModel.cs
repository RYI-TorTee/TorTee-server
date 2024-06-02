using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.Core.Domains.Entities;

namespace TorTee.BLL.Models.Requests.Mentorship
{
    public class MentorshipUpdateRequestModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Guid MentorId { get; set; }

        public Guid MenteeId { get; set; }

        public Guid Id { get; set; }
    }
}
