using System.ComponentModel.DataAnnotations;

namespace TorTee.Core.Dtos
{
    public class UserToRegisterDTO
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
