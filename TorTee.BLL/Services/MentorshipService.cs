using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Responses.Mentees;
using TorTee.BLL.Models.Responses.Mentors;
using TorTee.BLL.Services.IServices;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class MentorshipService : IMentorshipService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MentorshipService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ServiceActionResult> GetMyMentees(Guid mentorId)
        {
            var menteeQueryable = (await _unitOfWork.MentorshipRepository.GetAvailableMentorshipByMentorId(mentorId))
                .Include(m=>m.Mentee)
                .Select(m=>m.Mentee);
            return new ServiceActionResult(true) { Data = menteeQueryable.ProjectTo<MenteeResponse>(_mapper.ConfigurationProvider) };
        }

        public async Task<ServiceActionResult> GetMyMentors(Guid menteeId)
        {
            var menteeQueryable = (await _unitOfWork.MentorshipRepository.GetAvailableMentorshipByMenteeId(menteeId))
                .Include(m => m.Mentor)
                .Select(m => m.Mentor);
            return new ServiceActionResult(true) { Data = menteeQueryable.ProjectTo<MentorOverviewResponse>(_mapper.ConfigurationProvider) };
        }
    }
}
