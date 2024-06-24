using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using TorTee.BLL.Exceptions;
using TorTee.BLL.Models;
using TorTee.BLL.Services.IServices;

namespace TorTee.BLL.Services
{
    public class UserClaimsService : IUserClaimsService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserClaimsService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        private ClaimsPrincipal User => _httpContextAccessor.HttpContext?.User;

        public UserClaims GetUserClaims()
        {
            if (User == null)
            {
                throw new UserNotFoundException("User did not logined");
            }

            return new UserClaims
            {
                UserId = Guid.TryParse(User.FindFirstValue(ClaimTypes.NameIdentifier), out var userId) ? userId : Guid.Empty,               
                Email = User.FindFirstValue(ClaimTypes.Email),
            };
        }
    }
}
