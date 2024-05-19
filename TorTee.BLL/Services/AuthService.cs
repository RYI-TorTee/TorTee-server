using TorTee.BLL.Services.IServices;
using TorTee.Common.Dtos;
using TorTee.Core.Dtos;

namespace TorTee.BLL.Services
{
    public class AuthService : IAuthService
    {
        public Task<UserToLoginDTO> LoginAsync(UserToLoginDTO userToLoginDTO)
        {
            throw new NotImplementedException();
        }

        public Task<UserDTO> RegisterAsync(UserToLoginDTO userToRegisterDTO)
        {
            throw new NotImplementedException();
        }
    }
}
