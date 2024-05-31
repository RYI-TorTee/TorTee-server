using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.Core.Domains.Entities;

namespace TorTee.BLL.Models.Requests.Assignment
{
    public class AssignmentUpdateRequestModel
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime AssignedDate { get; set; }
        public DateTime Deadline { get; set; }

        public Guid MentorId { get; set; }
        public Guid MenteeId { get; set; }
    }
}
