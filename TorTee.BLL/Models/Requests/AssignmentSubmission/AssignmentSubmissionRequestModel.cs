using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.BLL.Models.Requests.Assignment;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Domains.Enums;

namespace TorTee.BLL.Models.Requests.AssignmentSubmission
{
    public class AssignmentSubmissionRequestModel
    {
        public string? File { get; set; }
        public string? Description { get; set; }
        public float Grade { get; set; }
        public DateTime SubmitedDate { get; set; }
        public SubmissionStatus Status { get; set; } = SubmissionStatus.UNGRADED;

        public Guid AssignmentId { get; set; }
        public AssignmentRequestModel Assignment { get; set; } = null!;

    }
}
