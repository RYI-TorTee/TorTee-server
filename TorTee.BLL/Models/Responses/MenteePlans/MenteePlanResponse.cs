using TorTee.BLL.Models.Responses.Mentors;

namespace TorTee.BLL.Models.Responses.MenteePlans
{
    public class MenteePlanResponse
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int TotalSlot { get; set; }
        public double Price { get; set; }
        public string Status { get; set; } 
        public MentorOverviewResponse Mentor { get; set; } = null!;
    }
}
