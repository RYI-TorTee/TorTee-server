using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Users;
using TorTee.BLL.Models.Responses.Users;
using TorTee.BLL.Services.IServices;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IFileStorageService _fileStorageService;

        public AccountService(IUnitOfWork unitOfWork, IMapper mapper, IFileStorageService fileStorageService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _fileStorageService = fileStorageService;
        }
        public async Task<ServiceActionResult> GetDetails(Guid id)
        {            
            var entity = (await _unitOfWork.UserRepository.GetAllAsyncAsQueryable())
                .Where(u=>u.Id==id).Include(u=>u.UserSkills).FirstOrDefault()
                ?? throw new NullReferenceException("User are not found");
         
            return new ServiceActionResult() { Data = _mapper.Map<UserResponse>(entity) };
        }

        public async Task<ServiceActionResult> UpdateDetails(UserRequest request, Guid userId)
        {
            var user = await _unitOfWork.UserRepository.FindAsync(userId);
            ArgumentNullException.ThrowIfNull(nameof(user));

            _mapper.Map(request, user);

            if (request.ProfilePic != null)
            {
                var imageUrl = await _fileStorageService.UploadFileBlobAsync(request.ProfilePic);
                user.ProfilePic = imageUrl;
            }
            await _unitOfWork.CommitAsync();
            return new ServiceActionResult();
        }

        public Task<ServiceActionResult> UpdatePassword(UpdatePasswordRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
