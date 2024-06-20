using TorTee.BLL.Models.Responses.Roles;
using TorTee.BLL.Models.Responses.Skills;
using TorTee.Core.Domains.Entities;

namespace TorTee.BLL.Models.Responses.Users
{
    public class UserResponse
    {
        public Guid Id { get; set; } 
        public string FullName { get; set; } = null!;
        public string? ProfilePic { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Bio { get; set; }
        public string? Company { get; set; }
        public string? JobTitle { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<SkillReponse>? UserSkills { get; set; }
        public ICollection<RoleResponse>? UserRoles { get; set; }
    }
}
