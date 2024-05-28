using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.Core.Domains.Enums;

namespace TorTee.BLL.Models.Requests.MenteeApplication
{
    public class MenteeApplicationUpdateRequestModel
    {
      //  public DateTime AppliedDate { get; set; }
        public ApplicationStatus Status { get; set; } = ApplicationStatus.PENDING;
       // public Guid QuestionId { get; set; }

        public Guid Id { get; set; }


    }
}
