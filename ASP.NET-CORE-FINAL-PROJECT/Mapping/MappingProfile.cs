using ASP.NET_CORE_FINAL_PROJECT.Models;
using AutoMapper;
using Repository.Models;

namespace ASP.NET_CORE_FINAL_PROJECT.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Agent, AgentViewModel>();
            CreateMap<SliderItem, SliderItemViewModel>();
            CreateMap<Brand, BrandViewModel>();
        }
    }
}
