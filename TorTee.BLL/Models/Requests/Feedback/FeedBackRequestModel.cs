using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.Core.Domains.Entities;

namespace TorTee.BLL.Models.Requests.Feedback
{
    public class FeedBackRequestModel
    {
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime CreatedDate { get; set; }

        public Guid MentorId { get; set; }

        public Guid MenteeId { get; set; }
    }
}
