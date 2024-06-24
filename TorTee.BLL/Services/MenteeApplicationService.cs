﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.MenteeApplications;
using TorTee.BLL.Models.Responses.MenteeApplications;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Domains.Enums;
using TorTee.DAL;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TorTee.BLL.Services
{
    public class MenteeApplicationService : IMenteeApplicationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MenteeApplicationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ServiceActionResult> CreateMenteeApplication(CreateMenteeApplicationRequest request, Guid currentUserId)
        {
            var menteePlan = (await _unitOfWork.MentorPlanRepository.GetAllAsyncAsQueryable())
                .Where(m => m.Id == request.MenteePlanId)
                .Include(m => m.MenteeApplications)
                .FirstOrDefault() ?? throw new NullReferenceException("Invalid mentee plan");

            var isInMentorPlan = menteePlan.MenteeApplications?.Any(ma => ma.UserId == currentUserId
            && ma.EndDate > DateTime.Now
            && ma.Status == Core.Domains.Enums.ApplicationStatus.PAID) ?? false;

            if(isInMentorPlan)
                return new ServiceActionResult(false) { Detail = "You are already in mentorship plan" };

            var isRemainingSlot = menteePlan.TotalSlot >= menteePlan.MenteeApplications?.Where(m => m.Status == ApplicationStatus.ACCEPTED).Count();
            if (!isRemainingSlot)
                return new ServiceActionResult(false) { Detail = "This mentor is full slot for mentoring" };

            var applicationEntity = _mapper.Map<MenteeApplication>(request);
            applicationEntity.UserId = currentUserId;
            applicationEntity.Price = menteePlan.Price;

            await _unitOfWork.MenteeApplicationRepository.AddAsync(applicationEntity);
            await _unitOfWork.CommitAsync();
            return new ServiceActionResult(true);
        }

        public async Task<ServiceActionResult> GetAllMenteeApplicationsReceived(Guid mentorId)
        {
            var applications = await (await _unitOfWork.MenteeApplicationRepository.GetAllAsyncAsQueryable())
                .Include(a => a.MenteePlan)
                .ThenInclude(p => p.Mentor)
                .Where(a => a.MenteePlan.MentorId == mentorId)
                .Include(a => a.User)
                .ToListAsync(); ;

            return new ServiceActionResult(true) { Data = _mapper.Map<List<MenteeApplication>, List<MenteeApplicationResponse>>(applications) };

        }

        public async Task<ServiceActionResult> GetAllMenteeApplicationsSent(Guid menteeId)
        {
            var applications = await (await _unitOfWork.MenteeApplicationRepository.GetAllAsyncAsQueryable())
                 .Where(a => a.UserId == menteeId)
                .Include(a => a.MenteePlan)
                .ThenInclude(p => p.Mentor)
                .ToListAsync();

            return new ServiceActionResult(true) { Data = _mapper.Map<List<MenteeApplication>, List<MenteeApplicationResponse>>(applications) };
        }

        public async Task<ServiceActionResult> GetMenteeApplicationDetails(Guid Id)
        {
            var application = (await _unitOfWork.MenteeApplicationRepository.GetAllAsyncAsQueryable())
                .Where(a => a.Id == Id)
                .Include(a => a.User)
                .Include(a => a.MenteePlan)
                .ThenInclude(p => p.Mentor)
                .Include(a => a.MenteeApplicationAnswers!)
                .ThenInclude(ans => ans.Question)
                .FirstOrDefault();
            return new ServiceActionResult(true) { Data = _mapper.Map<MenteeApplicationResponse>(application) };
        }

        public async Task<ServiceActionResult> UpdateMenteeApplicationStatus(UpdateMenteeApplicationRequest request)
        {
            var application = await _unitOfWork.MenteeApplicationRepository.FindAsync(request.Id);
            if (application.Status != ApplicationStatus.PENDING || application.Status.ToString().Equals(request.Status, StringComparison.OrdinalIgnoreCase))
            {
                return new ServiceActionResult(false, $"Application already {application.Status.ToString()}");
            }

            var canParsed = Enum.TryParse(request.Status, true, out ApplicationStatus status);
            if (!canParsed)
            {
                return new ServiceActionResult(false, $"Invalid application status {request.Status}");
            }

            application.Status = status;

            await _unitOfWork.CommitAsync();

            return new ServiceActionResult(true);
        }
    }
}
