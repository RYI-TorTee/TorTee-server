using AutoMapper;
using TorTee.BLL.Models.Requests.Answers;
using TorTee.BLL.Models.Requests.Assignments;
using TorTee.BLL.Models.Requests.MentorApplications;
using TorTee.BLL.Models.Requests.Messages;
using TorTee.BLL.Models.Requests.Submissions;
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
using TorTee.Core.Domains.Entities;
using TorTee.Core.Dtos;

namespace TorTee.BLL.Utilities.AutoMapperProfiles
{
    public static class AutoMapperProfiles
    {
        public class AutoMapperProfile : Profile
        {
            public AutoMapperProfile()
            {
                #region user mapper

                CreateMap<UserToRegisterDTO, User>()
               .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
               .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Email))
               .ForMember(dest => dest.PasswordHash, opt => opt.Ignore());

                CreateMap<User, MentorOverviewResponse>()
                   .ForMember(dest => dest.Skills, opt => opt.MapFrom(src => src.UserSkills.Select(us => new SkillReponse { SkillName = us.Skill.SkillName })));

                CreateMap<User, MenteeResponse>();

                #endregion

                #region mentor application mapper

                CreateMap<CreateMentorApplicationRequest, MentorApplication>()
                    .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                    .ForMember(dest => dest.CV, opt => opt.Ignore());

                CreateMap<MentorApplication, MentorApplicationResponse>();

                #endregion

                #region skill mapper              

                CreateMap<Skill, SkillReponse>();

                #endregion

                #region message mapper
                CreateMap<CreateMessageRequest, Message>();
                CreateMap<Message, MessageResponse>();
                #endregion

                #region assignment mapper

                CreateMap<CreateAssignmentRequest, Assignment>();
                CreateMap<Assignment, AssignmentResponse>();

                #endregion

                #region submission mapper

                CreateMap<CreateSubmissionRequest, AssignmentSubmission>();
                CreateMap<AssignmentSubmission, AssignmentSubmissionResponse>();

                #endregion

                #region application question mapper

                CreateMap<ApplicationQuestion, ApplicationQuestionResponse>();

                #endregion

                #region mentee application mapper

                CreateMap<MenteeApplication, MenteeApplicationResponse>()
                    .ForMember(dest => dest.Status, otp => otp.MapFrom(src => src.Status.ToString()));

                #endregion

                #region mentee plan mapper

                CreateMap<MenteePlan, MenteePlanResponse>()
                    .ForMember(dest => dest.Status, otp => otp.MapFrom(src => src.Status.ToString()));

                #endregion

                #region answer mapper

                CreateMap<MenteeApplicationAnswerRequest, MenteeApplicationAnswer>()
;
                CreateMap<MenteeApplicationAnswer, AnswerResponses>()
                    .ForMember(dest => dest.Question, opt => opt.MapFrom(src => src.Question.Content));
                #endregion
            }
        }
    }

}
