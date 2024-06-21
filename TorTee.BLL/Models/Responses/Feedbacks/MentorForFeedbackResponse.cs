using TorTee.BLL.Models.Responses.Users;

namespace TorTee.BLL.Models.Responses.Feedbacks
{
    public class MentorForFeedbackResponse 
    {
        public Guid MenteeApplicationId { get; set; }
        public bool IsFeedbacked { get; set; }
        public UserResponse UserResponse { get; set; }

    }
}
