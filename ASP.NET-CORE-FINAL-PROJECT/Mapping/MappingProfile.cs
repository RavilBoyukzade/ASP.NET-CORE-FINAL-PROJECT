using ASP.NET_CORE_FINAL_PROJECT.Models;
using AutoMapper;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE_FINAL_PROJECT.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Agent, AgentViewModel>();
            CreateMap<SliderItem, SliderItemViewModel>();
        }
    }
}
