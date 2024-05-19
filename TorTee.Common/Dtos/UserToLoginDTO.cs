using System.ComponentModel.DataAnnotations;

namespace TorTee.Common.Dtos
{
    public class UserToLoginDTO
    {
        [Required]
        [EmailAddress] 
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
