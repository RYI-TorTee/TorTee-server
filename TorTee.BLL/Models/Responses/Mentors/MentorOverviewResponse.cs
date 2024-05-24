using TorTee.BLL.Models.Responses.Skills;

namespace TorTee.BLL.Models.Responses.Mentors
{
    public class MentorOverviewResponse
    {
        public string? FullName { get; set; }
        public string? ProfilePic { get; set; }
        public string? Company { get; set; }
        public string? JobTitle { get; set; }
        public ICollection<SkillReponse>? Skills { get; set; }
    }
}
