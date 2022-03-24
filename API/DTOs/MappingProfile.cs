using API.DTO;
using AutoMapper;
using Domain;

namespace API.DTOs
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Activity, ActivityDTO>().ReverseMap();
        }
    }
}
