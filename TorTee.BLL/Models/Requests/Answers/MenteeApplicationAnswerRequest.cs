namespace TorTee.BLL.Models.Requests.Answers
{
    public class MenteeApplicationAnswerRequest
    {
        public string? ResponseContent { get; set; }
        public Guid QuestionId { get; set; }
    }
}
