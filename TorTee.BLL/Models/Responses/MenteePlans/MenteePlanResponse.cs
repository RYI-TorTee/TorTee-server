using TorTee.BLL.Models.Responses.Mentors;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Domains.Enums;

namespace TorTee.BLL.Models.Responses.MenteePlans
{
    public class MenteePlanResponse
    {
        public string? DescriptionOfPlan { get; set; }
        public int CallPerMonth { get; set; }
        public int DurationOfMeeting { get; set; }
        public int TotalSlot { get; set; }
        public double Price { get; set; }

        public Guid MentorId { get; set; }
        public User Mentor { get; set; } = null!;

        public ICollection<MenteeApplication>? MenteeApplications { get; set; }
        //public MentorOverviewResponse Mentor { get; set; } = null!;
    }
}
