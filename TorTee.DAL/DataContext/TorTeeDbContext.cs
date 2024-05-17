using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TorTee.Core.Domains.Entities;

namespace TorTee.DAL.DataContext
{
    public class TorTeeDbContext : IdentityDbContext<User, Role,
    Guid, IdentityUserClaim<Guid>, UserRole, IdentityUserLogin<Guid>,
    IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
    {
        public TorTeeDbContext()
        {
            
        }
        public TorTeeDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<ApplicationQuestion> ApplicationQuestion { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<BookingCall> BookingCalls { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<MenteeApplication> MenteeApplications { get; set; }
        public DbSet<MenteeApplicationAnswer> MenteeApplicationAnswers { get; set; }
        public DbSet<MenteePlan> MenteePlans { get; set; }
        public DbSet<MentorApplication> MentorApplications { get; set; }
        public DbSet<Mentorship> Mentorships { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
