namespace TorTee.BLL.Models.Requests.Commons
{
    public class MentorApplicationRequest : PagingRequest
    {
        public string Status { get; set; } = string.Empty;
        public string? Search { get; set; }       
        public bool IsDesc { get; set; } = false;
    }
}
