using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.Core.Domains.Entities;

namespace TorTee.Core.Dtos
{
    public class MentorDTO
    {
        public Guid Id { get; set; }
        public string? FullName { get; set; }
        public string? ProfilePic { get; set; }
        public string? BankAccount { get; set; }
        public string? Bio { get; set; }
        public string? Company { get; set; }
        public string? JobTitle { get; set; }

        public ICollection<Feedback> FeedbacksReceived { get; set; }
     
        public ICollection<UserSkill> UserSkills { get; set; }
        public ICollection<MenteePlan> MenteePlans { get; set; }
    }
}
