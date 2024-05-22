using AutoMapper;
using TorTee.BLL.RequestModel;
using TorTee.Core.Domains.Entities;
namespace TorTee.BLL.Utilities.AutoMapperProfiles
{
    public static class AutoMapperProfiles
    {
        public class AutoMapperProfile : Profile
        {
            public AutoMapperProfile()
            {
                //CreateMap<User, UserDTO>().ReverseMap();
                CreateMap<User, MentorProfileUpdateRequestModel>().ReverseMap();  
            }
        }
    }

}
