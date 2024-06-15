namespace TorTee.BLL.Models.Requests.Skills
{
    public class UserSkillsRequest
    {
        public ICollection<SkillRequest> Skills { get; set; } = null!;
    }
    
    public class SkillRequest
    {
        public Guid Id { get; set; }
    }
}
