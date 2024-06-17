using TorTee.BLL.Models.Responses.Answers;
using TorTee.BLL.Models.Responses.MenteePlans;
using TorTee.BLL.Models.Responses.Mentees;
using TorTee.BLL.Models.Responses.Users;

namespace TorTee.BLL.Models.Responses.MenteeApplications
{
    public class MenteeApplicationResponse
    {
        public Guid Id { get; set; } 
        public DateTime AppliedDate { get; set; } 
        public string? Status { get; set; }
        public double? Price { get; set; }
        public MenteeResponse? User { get; set; }
        public UserResponse? Mentor { get; set; }
        public MenteePlanResponse MenteePlan { get; set; } = null!;
        public ICollection<AnswerResponses>? MenteeApplicationAnswers { get; set; }
    }
}
