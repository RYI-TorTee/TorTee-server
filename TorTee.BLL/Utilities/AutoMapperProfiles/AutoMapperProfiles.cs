using AutoMapper;
using TorTee.BLL.Models.Requests.Answers;
using TorTee.BLL.Models.Requests.Assignments;
using TorTee.BLL.Models.Requests.MenteeApplications;
using TorTee.BLL.Models.Requests.MentorApplications;
using TorTee.BLL.Models.Requests.Messages;
using TorTee.BLL.Models.Requests.Submissions;
using TorTee.BLL.Models.Requests.Users;
using TorTee.BLL.Models.Responses.Answers;
using TorTee.BLL.Models.Responses.ApplicationQuestions;
using TorTee.BLL.Models.Responses.Assignments;
using TorTee.BLL.Models.Responses.AssignmentSubmissions;
using TorTee.BLL.Models.Responses.MenteeApplications;
using TorTee.BLL.Models.Responses.MenteePlans;
using TorTee.BLL.Models.Responses.Mentees;
using TorTee.BLL.Models.Responses.MentorApplications;
using TorTee.BLL.Models.Responses.Mentors;
using TorTee.BLL.Models.Responses.Messages;
using TorTee.BLL.Models.Responses.Skills;
using TorTee.BLL.Models.Responses.Users;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Domains.Enums;
using TorTee.Core.Dtos;

namespace TorTee.BLL.Utilities.AutoMapperProfiles
{
    public static class AutoMapperProfiles
    {
        public class AutoMapperProfile : Profile
        {
            public AutoMapperProfile()
            {
                #region user 

                CreateMap<UserToRegisterDTO, User>()
               .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
               .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Email))
               .ForMember(dest => dest.PasswordHash, opt => opt.Ignore());

                CreateMap<User, MentorOverviewResponse>()
                   .ForMember(dest => dest.Skills, opt => opt.MapFrom(src => (src.UserSkills ?? new List<UserSkill>()).Select(us => new SkillReponse { SkillName = us.Skill.SkillName })));

                CreateMap<User, MenteeResponse>();

                CreateMap<User, UserResponse>();

                CreateMap<UserRequest, User>();

                CreateMap<User, AssignmentUserResponse>();

                #endregion

                #region mentor application 

                CreateMap<CreateMentorApplicationRequest, MentorApplication>()
                    .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                    .ForMember(dest => dest.CV, opt => opt.Ignore());

                CreateMap<MentorApplication, MentorApplicationResponse>();

                #endregion

                #region skill        

                CreateMap<UserSkill, SkillReponse>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.SkillId))
                    .ForMember(dest => dest.SkillName, opt => opt.MapFrom(src => src.Skill.SkillName));
                CreateMap<Skill, SkillReponse>();

                #endregion

                #region message
                CreateMap<CreateMessageRequest, Message>();
                CreateMap<Message, MessageResponse>();
                CreateMap<User, ChatBoxResponse>()
                    .ForMember(dest => dest.ChatPartnerName, opt => opt.MapFrom(src => src.FullName))
                    .ForMember(dest => dest.ChatPartnerId, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.ChatPartnerPhoto, opt => opt.MapFrom(src => src.ProfilePic));
                #endregion

                #region assignment

                CreateMap<CreateAssignmentRequest, Assignment>();
                CreateMap<Assignment, AssignmentDetailResponse>();
                CreateMap<Assignment, AssignmentResponse>()
                    .ForMember(dest => dest.TotalOfSubmission,
                    opt => opt.MapFrom(src => (src.Submissions ?? new List<AssignmentSubmission>()).Count()))
                .ForMember(dest => dest.IsSubmited,
                    opt => opt.MapFrom(src => (src.Submissions ?? new List<AssignmentSubmission>()).Count() > 0));

                #endregion

                #region submission

                CreateMap<CreateSubmissionRequest, AssignmentSubmission>();
                CreateMap<AssignmentSubmission, AssignmentSubmissionResponse>()
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()));

                #endregion

                #region application question 

                CreateMap<ApplicationQuestion, ApplicationQuestionResponse>();

                #endregion

                #region mentee application

                CreateMap<CreateMenteeApplicationRequest, MenteeApplication>();

                CreateMap<MenteeApplication, MenteeApplicationResponse>()
                    .ForMember(dest => dest.Status, otp => otp.MapFrom(src => src.Status.ToString()))
                    .ForMember(dest => dest.Mentor, otp => otp.MapFrom(src => src.MenteePlan.Mentor));

                #endregion

                #region mentee plan 

                CreateMap<MenteePlan, MenteePlanResponse>()
                    .ForMember(dest => dest.Status, otp => otp.MapFrom(src => src.TotalSlot - (src.MenteeApplications ?? new List<MenteeApplication>()).Where(m => m.Status == ApplicationStatus.ACCEPTED).Count() <= 0 ? "Full Slot" : "Available"))
                    .ForMember(dest => dest.RemainSlot, opt => opt.MapFrom(src => src.TotalSlot - (src.MenteeApplications ?? new List<MenteeApplication>()).Where(m => m.Status == ApplicationStatus.ACCEPTED).Count()));

                #endregion

                #region answer

                CreateMap<MenteeApplicationAnswerRequest, MenteeApplicationAnswer>()
;
                CreateMap<MenteeApplicationAnswer, AnswerResponses>()
                    .ForMember(dest => dest.Question, opt => opt.MapFrom(src => src.Question.Content));
                #endregion
            }
        }
    }

}
