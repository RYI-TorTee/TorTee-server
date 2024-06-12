namespace TorTee.BLL.Models.Requests.MenteeApplications
{
    public class UpdateMenteeApplicationRequest
    {
        public Guid Id { get; set; }
        public string Status { get; set; } = null!;
    }
}
