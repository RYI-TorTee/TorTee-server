using AutoMapper;
using TorTee.BLL.Models.Requests.MentorApplications;
using TorTee.BLL.Models.Requests.Messages;
using TorTee.BLL.RequestModel;
using TorTee.BLL.Models.Requests;
using TorTee.BLL.Models.Responses.Mentors;
using TorTee.BLL.Models.Responses.Messages;
using TorTee.BLL.Models.Responses.Skills;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Dtos;
using TorTee.BLL.Models.Requests.MenteeApplicationAnswer;
using TorTee.BLL.Models.Requests.MenteeApplication;

namespace TorTee.BLL.Utilities.AutoMapperProfiles
{
    public static class AutoMapperProfiles
    {
        public class AutoMapperProfile : Profile
        {
            public AutoMapperProfile()
            {

                CreateMap<User, MentorProfileUpdateRequestModel>().ReverseMap();  
                CreateMap<UserToRegisterDTO, User>()
               .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
               .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Email)) 
               .ForMember(dest => dest.PasswordHash, opt => opt.Ignore());

                CreateMap<CreateMentorApplicationRequest, MentorApplication>()
                    .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                    .ForMember(dest=>dest.CV, opt=>opt.Ignore());

                CreateMap<User, MentorOverviewResponse>()
                    .ForMember(dest => dest.Skills, opt => opt.MapFrom(src => src.UserSkills.Select(us => new SkillReponse { SkillName = us.Skill.SkillName })));

                CreateMap<Skill, SkillReponse>();
                CreateMap<User, MentorDTO>().ReverseMap(); 
                CreateMap<MenteeApplicationAnswer, MenteeApplicationAnswerCreateRequestModel>().ReverseMap();
                CreateMap<MenteeApplication, MenteeApplicationCreateRequestModel>().ReverseMap();

                CreateMap<CreateMessageRequest, Message>();

                CreateMap<Message, MessageResponse>(); 
            }
        }
    }

}
