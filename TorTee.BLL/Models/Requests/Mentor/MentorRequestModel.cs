using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.BLL.Models.Requests.Feedback;
using TorTee.BLL.Models.Requests.MenteePlan;
using TorTee.BLL.Models.Requests.UserSkills;
using TorTee.Core.Domains.Entities;

namespace TorTee.BLL.Models.Requests.Mentor
{
    public class MentorRequestModel
    {
        public string FullName { get; set; } = null!;
        public string? ProfilePic { get; set; }
        public string? BankAccount { get; set; }
        public string? Bio { get; set; }
        public string? Company { get; set; }
        public string? JobTitle { get; set; }

        public ICollection<FeedBackRequestModel> FeedbacksReceived { get; set; }

        public ICollection<UserSkillRequestModel> UserSkills { get; set; }
        public ICollection<MenteePlanRequestModel> MenteePlans { get; set; }
    }
}
