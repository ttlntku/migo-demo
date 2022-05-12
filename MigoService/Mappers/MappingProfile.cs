using AutoMapper;
using Core.Entities;
using MigoService;

namespace Application.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //configure mapping profile for employee
            CreateMap<StoryEntity, Story>().ReverseMap();
            CreateMap<TopicEntity, Topic>().ReverseMap();
        }
    }
}
