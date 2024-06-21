using System.ComponentModel.DataAnnotations;

namespace TorTee.BLL.Models.Requests.Feedbacks
{
    public class FeedbackRequest
    {
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int Rating { get; set; }
        public string? Comment { get; set; }     
        public Guid MenteeApplicationId { get; set; }     
    }
}
