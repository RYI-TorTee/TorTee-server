namespace TorTee.BLL.Services
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.Configuration;
    using System;
    using TorTee.BLL.Services.IServices;

    public class CookieService : ICookieService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;

        public CookieService(IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
        }

        public void SetJwtCookie(string token)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.Now.AddMinutes(60),
                Secure = true,
                IsEssential = true,
                SameSite = SameSiteMode.None 
            };

            _httpContextAccessor.HttpContext?.Response.Cookies.Append("token", token, cookieOptions);
        }
    }

}
