using Admin.Models.Faq;
using AutoMapper;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Faq, FaqViewModel>();
            CreateMap<FaqViewModel, Faq>();
        }
    }
}
