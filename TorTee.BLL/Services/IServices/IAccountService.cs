using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Users;

namespace TorTee.BLL.Services.IServices
{
    public interface IAccountService
    {
        Task<ServiceActionResult> GetDetails(Guid id);

        Task<ServiceActionResult> UpdateDetails(UserRequest request, Guid userId);
        Task<ServiceActionResult> UpdatePassword(UpdatePasswordRequest request, Guid userId);
    }
}
