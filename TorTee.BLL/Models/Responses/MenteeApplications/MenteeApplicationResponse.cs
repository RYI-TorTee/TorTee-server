using TorTee.BLL.Models.Responses.ApplicationQuestions;
using TorTee.BLL.Models.Responses.MenteePlans;
using TorTee.BLL.Models.Responses.Mentees;

namespace TorTee.BLL.Models.Responses.MenteeApplications
{
    public class MenteeApplicationResponse
    {
        public Guid Id { get; set; } 
        public DateTime AppliedDate { get; set; } 
        public string Status { get; set; }
        public MenteeResponse? User { get; set; }
        public MenteePlanResponse MenteePlan { get; set; } = null!;
        public ICollection<ApplicationQuestionResponse>? MenteeApplicationAnswers { get; set; }
    }
}
