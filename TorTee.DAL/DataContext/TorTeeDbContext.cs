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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(ur => new { ur.UserId, ur.RoleId });

                entity.HasOne(ur => ur.User)
                      .WithMany(u => u.UserRoles)
                      .HasForeignKey(ur => ur.UserId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(ur => ur.Role)
                      .WithMany(r => r.UserRoles)
                      .HasForeignKey(ur => ur.RoleId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Assignment>()
                .HasOne(a => a.Mentor)
                .WithMany(u => u.AssignmentsGiven)
                .HasForeignKey(a => a.MentorId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Assignment>()
                .HasOne(a => a.Mentee)
                .WithMany(u => u.AssignmentsReceived)
                .HasForeignKey(a => a.MenteeId)
                .OnDelete(DeleteBehavior.Restrict); 


            modelBuilder.Entity<Feedback>()
                .HasOne(a => a.Mentor)
                .WithMany(u => u.FeedbacksReceived)
                .HasForeignKey(a => a.MentorId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Feedback>()
                .HasOne(a => a.Mentee)
                .WithMany(u => u.FeedbacksGiven)
                .HasForeignKey(a => a.MenteeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Mentorship>()
                .HasOne(a => a.Mentor)
                .WithMany(u => u.MentorshipAsMentor)
                .HasForeignKey(a => a.MentorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Mentorship>()
                .HasOne(a => a.Mentee)
                .WithMany(u => u.MentorshipAsMentee)
                .HasForeignKey(a => a.MenteeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Message>()
                .HasOne(a => a.Sender)
                .WithMany(u => u.MessagesSent)
                .HasForeignKey(a => a.SenderId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Message>()
                .HasOne(a => a.Receiver)
                .WithMany(u => u.MessagesReceived)
                .HasForeignKey(a => a.ReceiverId)
                .OnDelete(DeleteBehavior.Restrict);
            

            modelBuilder.Entity<Notification>()
                .HasOne(a => a.Receiver)
                .WithMany(u => u.Notifications)
                .HasForeignKey(a => a.ReceiverId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MenteeApplication>()
                .HasOne(m => m.MenteePlan)
                .WithMany(p => p.MenteeApplications)
                .HasForeignKey(m => m.MenteePlanId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BookingCall>()
                .HasOne(c=>c.Session)
                .WithMany(s=>s.BookingCalls)
                .HasForeignKey(c=>c.SessionId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
