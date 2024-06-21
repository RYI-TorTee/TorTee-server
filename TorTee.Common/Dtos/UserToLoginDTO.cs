using System.ComponentModel.DataAnnotations;

namespace TorTee.Common.Dtos
{
    public class UserToLoginDTO
    {
        [Required]       
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
