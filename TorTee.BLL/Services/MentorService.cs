using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Constants;
using TorTee.Core.Domains.Entities;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class MentorService : IMentorService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public MentorService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ServiceActionResult> BrowseMentorList(QueryParametersRequest queryParameters)
        {
            var mentorQuery = _unitOfWork.UserRepository.GetAllMentorAsync();

            return new ServiceActionResult(true) { Data = null};
        }

        
    }
}
