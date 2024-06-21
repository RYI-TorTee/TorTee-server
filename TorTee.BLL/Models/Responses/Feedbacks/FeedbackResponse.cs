namespace TorTee.BLL.Models.Responses.Feedbacks
{
    public class FeedbackResponse
    {
        public Guid Id { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public string? Reply { get; set; }
        public string? CreatedUserName { get; set; }
        public string? CreatedUserProfilePic { get; set; }
        public DateTime CreatedDate { get; set; } 
    }
}
