using Microsoft.AspNetCore.Identity;

namespace TorTee.Core.Domains.Entities
{
    public class Role : IdentityRole<Guid>
    {
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
