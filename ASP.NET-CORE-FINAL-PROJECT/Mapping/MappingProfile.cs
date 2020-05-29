using ASP.NET_CORE_FINAL_PROJECT.Models;
using AutoMapper;
using Repository.Models;
using System.Linq;

namespace ASP.NET_CORE_FINAL_PROJECT.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Agent, AgentViewModel>();
            CreateMap<SliderItem, SliderItemViewModel>();
            CreateMap<Brand, BrandViewModel>();
            CreateMap<Faq, FaqViewModel>();
            CreateMap<Testimonial, TestimonialViewModel>();
            CreateMap<Setting, SettingViewModel>();
            CreateMap<AboutItem, AboutViewModel>();
            CreateMap<AboutCard, AboutCardViewModel>();
            CreateMap<Service, ServiceViewModel>();
            CreateMap<Area, AreaViewModel>();
            CreateMap<BestPlan, BestPlanViewModel>();
            CreateMap<BestPlanCateg, BestPlanCategViewModel>();
            CreateMap<Blog, BlogViewModel>();
            CreateMap<BlogImage, BlogImageViewModel>();
            CreateMap<BlogSlogan, BlogSloganViewModel>();
            CreateMap<CaseStud, CaseStudViewModel>();
            CreateMap<CaseStudCollapse, CaseStudCollapseViewModel>();
            CreateMap<CaseStudSpec, CaseStudSpecViewModel>();
        }
    }
}
