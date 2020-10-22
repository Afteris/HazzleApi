using HazzleApi.Models;
using AutoMapper;

namespace HazzleApi
{

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ExampleModel, ExampleVM>();
            CreateMap<ExampleVM, ExampleModel>();
        }
    }

}
