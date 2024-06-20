using System.ComponentModel.DataAnnotations;

namespace TorTee.BLL.Models.Requests.Users
{
    public class CreateStaffAccountRequest
    {
        public string Username { get; set; } = null!;
        public string FullName { get; set; } = null!;
        [Phone]
        public string PhoneNumber { get; set; } = null!;
    }
}
