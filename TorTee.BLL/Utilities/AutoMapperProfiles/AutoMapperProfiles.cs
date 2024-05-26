﻿using AutoMapper;
using TorTee.BLL.Models.Requests.MentorApplications;
using TorTee.BLL.Models.Requests.Messages;
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
                CreateMap<UserToRegisterDTO, User>()
               .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
               .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Email)) 
               .ForMember(dest => dest.PasswordHash, opt => opt.Ignore());

                CreateMap<CreateMentorApplicationRequest, MentorApplication>()
                    .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));

                CreateMap<User, MentorOverviewResponse>()
                    .ForMember(dest => dest.Skills, opt => opt.MapFrom(src => src.UserSkills.Select(us => new SkillReponse { SkillName = us.Skill.SkillName })));

                CreateMap<Skill, SkillReponse>();

                CreateMap<CreateMessageRequest, Message>();

                CreateMap<Message, MessageResponse>(); 
            }
        }
    }

}
