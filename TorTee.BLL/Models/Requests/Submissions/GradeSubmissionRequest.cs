using System.ComponentModel.DataAnnotations;

namespace TorTee.BLL.Models.Requests.Submissions
{
    public class GradeSubmissionRequest
    {
        public Guid Id { get; set; }
        public string? CommentOfMentor { get; set; }
        [Range(0, 10, ErrorMessage = "The grade must be in 0 to 10")]
        public float Grade { get; set; }
    }
}
