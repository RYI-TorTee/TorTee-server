using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.Core.Domains.Enums;

namespace TorTee.BLL.Models.Requests.MentorApplications
{
    public class MentorApplicationRequestModel
    {
        public Guid Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public DateTime AppliedDate { get; set; } = DateTime.Now;
        public string Category { get; set; } = null!;
        public string CV { get; set; } = null!;
        public string Bio { get; set; } = null!;
        public string Reason { get; set; } = null!;
        public string Achievement { get; set; } = null!;
        public string? Company { get; set; }
        public string? JobTitle { get; set; }

        public ApplicationStatus Status { get; set; } = ApplicationStatus.PENDING;

        public Guid? UserId { get; set; }
    }
}
