using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Domains.Enums;

namespace TorTee.BLL.Models.Requests.MentorApplications
{
    public class MentorApplicationUpdateRequestModel
    {
      
        public ApplicationStatus Status { get; set; } = ApplicationStatus.PENDING;

        public Guid Id { get; set; }
    }
}
