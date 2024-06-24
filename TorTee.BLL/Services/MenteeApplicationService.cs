using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using TorTee.API.SignalR;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.MenteeApplications;
using TorTee.BLL.Models.Requests.Notifications;
using TorTee.BLL.Models.Responses.MenteeApplications;
using TorTee.BLL.Models.Responses.Notifications;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Domains.Enums;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class MenteeApplicationService : IMenteeApplicationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHubContext<NotificationHub> _hubContext;

        public MenteeApplicationService(IUnitOfWork unitOfWork, IMapper mapper, IHubContext<NotificationHub> hubContext)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _hubContext = hubContext;
        }
        public async Task<ServiceActionResult> CreateMenteeApplication(CreateMenteeApplicationRequest request, Guid currentUserId)
        {
            var currentMentee = await _unitOfWork.UserRepository.FindAsync(currentUserId);
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

            //Send notification to mentor
            var newNoti = new NotificationRequest(){
                Content = $"You have a new application from {currentMentee.FullName}",
                SenderId = currentUserId,
                ReceiverId = menteePlan.MentorId,
            };
            var noti = _mapper.Map<Notification>(newNoti);
            await _unitOfWork.NotificationRepository.AddAsync(noti);
            await _unitOfWork.CommitAsync();

            var notiToReturn = _mapper.Map<NotificationResponse>(noti);
            notiToReturn.SenderAvatar = currentMentee.ProfilePic;

            if (NotificationHub.TryGetConnectionId(newNoti.ReceiverId.ToString(), out var connectionId))
            {
                await _hubContext.Clients.Client(connectionId).SendAsync("ReceiveNotification", notiToReturn);
            }           

            return new ServiceActionResult(true) { Data = newNoti};
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
            var application = (await _unitOfWork.MenteeApplicationRepository.GetAllAsyncAsQueryable())
                .Where(a=>a.Id==request.Id)
                .Include(a=>a.User)
                .Include(a=>a.MenteePlan)
                .ThenInclude(a=>a.Mentor)
                .FirstOrDefault() ?? throw new NullReferenceException("Invalid application");

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

            //TODO: Send notification to user
            var newNoti = new NotificationRequest()
            {
                Content = $"Application to {application.MenteePlan.Mentor.FullName} is {application.Status.ToString()}",
                SenderId = application.MenteePlan.MentorId,
                ReceiverId = application.UserId,
            };
            var noti = _mapper.Map<Notification>(newNoti);
            await _unitOfWork.NotificationRepository.AddAsync(noti);
            await _unitOfWork.CommitAsync();

            var notiToReturn = _mapper.Map<NotificationResponse>(noti);
            notiToReturn.SenderAvatar = application.MenteePlan.Mentor.ProfilePic;

            if (NotificationHub.TryGetConnectionId(noti.ReceiverId.ToString(), out var connectionId))
            {
                await _hubContext.Clients.Client(connectionId).SendAsync("ReceiveNotification", notiToReturn);
            }

            return new ServiceActionResult(true);
        }
    }
}
