namespace TorTee.BLL.Models.Responses.Mentees
{
    public class MenteeResponse
    {
        public string FullName { get; set; } = null!;
        public string? ProfilePic { get; set; }
        public string? Email { get; set; }        
        public string? PhoneNumber { get; set; }        
        public string? Bio { get; set; }
        public string? Company { get; set; }
        public string? JobTitle { get; set; }
    }
}
