using TorTee.Core.Domains.Entities;

namespace TorTee.BLL.Services.IServices
{
    public interface ITokenService
    {
        Task<string> CreateToken(User user);
    }
}
