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


            modelBuilder.Entity<ApplicationQuestion>().HasData(
            new ApplicationQuestion
            {
                Id = Guid.NewGuid(),
                Content = "What best describes the goal of your mentorship?"
            },
            new ApplicationQuestion
            {
                Id = Guid.NewGuid(),
                Content = "When would you like to reach that goal?"
            },
            new ApplicationQuestion
            {
                Id = Guid.NewGuid(),
                Content = "Write a message to Mentor"
            }
        );

            modelBuilder.Entity<Skill>().HasData(
            new Skill { Id = Guid.NewGuid(), SkillName = "Project Management" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Software Development" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Data Analysis" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Digital Marketing" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Machine Learning" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Communication" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Team Leadership" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Problem Solving" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Critical Thinking" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Financial Analysis" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Graphic Design" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Customer Service" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Sales" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Strategic Planning" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Web Development" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Mobile Development" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Cloud Computing" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Cybersecurity" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Database Management" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Network Administration" },
            new Skill { Id = Guid.NewGuid(), SkillName = "DevOps" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Artificial Intelligence" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Blockchain" },
            new Skill { Id = Guid.NewGuid(), SkillName = "IT Support" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Time Management" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Adaptability" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Collaboration" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Conflict Resolution" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Creativity" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Work Ethic" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Interpersonal Skills" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Emotional Intelligence" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Business Analysis" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Product Management" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Business Strategy" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Operations Management" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Supply Chain Management" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Entrepreneurship" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Negotiation" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Risk Management" },
            new Skill { Id = Guid.NewGuid(), SkillName = "SEO (Search Engine Optimization)" },
            new Skill { Id = Guid.NewGuid(), SkillName = "SEM (Search Engine Marketing)" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Content Marketing" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Social Media Marketing" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Brand Management" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Market Research" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Email Marketing" },
            new Skill { Id = Guid.NewGuid(), SkillName = "Public Relations" }
        );
        }
    }
}
