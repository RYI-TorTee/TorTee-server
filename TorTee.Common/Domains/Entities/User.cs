﻿using Microsoft.AspNetCore.Identity;

namespace TorTee.Core.Domains.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string FullName { get; set; } = null!;
        public string? ProfilePic { get; set; }
        public string? BankAccount { get; set; }
        public string? Bio { get; set; }
        public string? Company { get; set; }
        public string? JobTitle { get; set; }

        //Common
        public ICollection<Notification> Notifications { get; set; }
        public ICollection<Message> MessagesSent { get; set; }
        public ICollection<Message> MessagesReceived { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }

        //Mentee
        public ICollection<Feedback> FeedbacksGiven { get; set; }
        public ICollection<Assignment> AssignmentsReceived { get; set; }
        public ICollection<BookingCall> BookingCallAsMentee { get; set; }
        public ICollection<Mentorship> MentorshipAsMentee { get; set; }
        public ICollection<MenteeApplication> MenteeApplications { get; set; }

        //Mentor
        public ICollection<Feedback> FeedbacksReceived { get; set; }
        public ICollection<Assignment> AssignmentsGiven { get; set; }        
        public ICollection<Session> Sessions { get; set; }        
        public ICollection<Mentorship> MentorshipAsMentor { get; set; }        
        public ICollection<UserSkill> UserSkills { get; set; }        
        public ICollection<MenteePlan> MenteePlans { get; set; }
        
    }
}
