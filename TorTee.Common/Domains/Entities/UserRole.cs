using Microsoft.AspNetCore.Identity;

namespace TorTee.Core.Domains.Entities
{
    public class UserRole : IdentityUserRole<Guid>
    {
        public User User { get; set; }
        public Role Role { get; set; }
    }
}
