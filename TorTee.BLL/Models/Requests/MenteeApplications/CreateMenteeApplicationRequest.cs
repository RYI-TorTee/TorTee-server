using TorTee.BLL.Models.Requests.Answers;

namespace TorTee.BLL.Models.Requests.MenteeApplications
{
    public class CreateMenteeApplicationRequest
    {  
        public Guid MenteePlanId { get; set; }
        public ICollection<MenteeApplicationAnswerRequest> MenteeApplicationAnswers { get; set; } = null!;
    }
}
