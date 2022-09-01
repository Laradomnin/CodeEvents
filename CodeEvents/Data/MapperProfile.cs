using AutoMapper;
using CodeEvents.Api.Controllers.Core.Dto;
using CodeEvents.Api.Controllers.Core.Entities;

namespace CodeEvents.Api.Data
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<CodeEvent,CodeEventDto>().ReverseMap();
            CreateMap<Lecture,LectureDto>().ReverseMap();   
        }
    }
}
