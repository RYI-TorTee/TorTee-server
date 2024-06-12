namespace TorTee.BLL.Models.Requests.Users
{
    public class UpdatePasswordRequest
    {
        public string CurrentPassword { get; set; } = null!;
        public string NewPassword { get; set; } = null!;
    }
}
