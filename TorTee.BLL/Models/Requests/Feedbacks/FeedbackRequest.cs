namespace TorTee.BLL.Models.Requests.Feedbacks
{
    public class FeedbackRequest
    {
        public int Rating { get; set; }
        public string? Comment { get; set; }     
        public Guid MenteeApplicationId { get; set; }     
    }
}
