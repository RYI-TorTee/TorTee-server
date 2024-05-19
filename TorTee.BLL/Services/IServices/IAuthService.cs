using TorTee.Common.Dtos;
using TorTee.Core.Dtos;

namespace TorTee.BLL.Services.IServices
{
    public interface IAuthService
    {
        Task<UserToLoginDTO> LoginAsync(UserToLoginDTO userToLoginDTO);
        Task<UserDTO> RegisterAsync(UserToLoginDTO userToRegisterDTO);
    }
}
