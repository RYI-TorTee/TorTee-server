using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.Core.Domains.Entities;

namespace TorTee.BLL.RequestModel
{
    public class MentorProfileUpdateRequestModel
    {
        public string? FullName { get; set; }
        public string? ProfilePic { get; set; }
        public string? BankAccount { get; set; }

        public Guid  Id { get; set; }

        //Mentor

      //  public ICollection<Mentorship> MentorshipAsMentor { get; set; }
       // public ICollection<UserSkill> UserSkills { get; set; }
    
    }
}
