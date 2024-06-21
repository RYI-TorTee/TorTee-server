using AutoMapper;
using Microsoft.AspNetCore.Identity;
using TorTee.BLL.Exceptions;
using TorTee.BLL.Models;
using TorTee.BLL.Services.IServices;
using TorTee.Common.Dtos;
using TorTee.Core.Domains.Constants;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Dtos;

namespace TorTee.BLL.Services
{
    public class AuthService : IAuthService
    {
        private readonly ITokenService _tokenService;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;
        private readonly ICookieService _cookieService;

        public AuthService(ITokenService tokenService,
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            IMapper mapper,
            RoleManager<Role> roleManager,
            IEmailService emailService,
            ICookieService cookieService)
        {
            _tokenService = tokenService;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _mapper = mapper;
            _emailService = emailService;
            _cookieService = cookieService;
        }

        public async Task<ServiceActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
                return new ServiceActionResult(false);

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
                throw new UserNotFoundException();

            var result = await _userManager.ConfirmEmailAsync(user, token);

            if (!result.Succeeded)
                return new ServiceActionResult(false) { Detail = result.Errors.First().Description };

            return new ServiceActionResult(true, "Email comfirmed");
        }

        public async Task<ServiceActionResult> LoginAsync(UserToLoginDTO userToLoginDTO)
        {
            var user = await _userManager.FindByNameAsync(userToLoginDTO.Email);
            if (user == null)
                throw new UserNotFoundException($"Invalid user with email {userToLoginDTO.Email}");

            var isEmailActivated = await _userManager.IsEmailConfirmedAsync(user);
            if (!isEmailActivated)
                throw new UnactivatedEmailException($"User with email {userToLoginDTO.Email} unconfirmed.");

            var result = await _signInManager.CheckPasswordSignInAsync(user, userToLoginDTO.Password, false);
            if (!result.Succeeded)
                throw new InvalidPasswordException($"Invalid password");

            var token = await _tokenService.CreateToken(user);
            _cookieService.SetJwtCookie(token);

            return new ServiceActionResult(true) { Data = new { roles = await _userManager.GetRolesAsync(user) } };
        }

        public async Task<ServiceActionResult> RegisterAsync(UserToRegisterDTO userToRegisterDTO)
        {
            var userEntity = _mapper.Map<User>(userToRegisterDTO);

            var result = await _userManager.CreateAsync(userEntity, userToRegisterDTO.Password);
            if (!result.Succeeded)
            {
                var error = result.Errors.First();
                return new ServiceActionResult(false, error.Description);
            }

            if (!await _roleManager.RoleExistsAsync(UserRoleConstants.MENTEE))
            {
                await _roleManager.CreateAsync(new Role { Name = UserRoleConstants.MENTEE });
            }
            var roleResult = await _userManager.AddToRoleAsync(userEntity, UserRoleConstants.MENTEE);
            if (!roleResult.Succeeded)
            {
                await _userManager.DeleteAsync(userEntity);
                throw new AddRoleException("Can not create account with role Mentee");
            }

            var token = await _userManager.GenerateEmailConfirmationTokenAsync(userEntity);
            await _emailService.SendEmailConfirmationAsync(userEntity, token);

            return new ServiceActionResult(true);
        }
    }
}
