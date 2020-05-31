using Admin.Models.Blog;
using Admin.Models.Faq;
using Admin.Models.Service;
using Admin.Models.Testimonial;
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
            CreateMap<Testimonial, TestimonialViewModel>();
            CreateMap<TestimonialViewModel, Testimonial>();
            CreateMap<Service, ServiceViewModel>();
            CreateMap<ServiceViewModel, Service>();
            CreateMap<Blog, BlogViewModel>();
            CreateMap<BlogViewModel, Blog>();
            CreateMap<BlogImage, BlogImageViewModel>();
            CreateMap<BlogImageViewModel, BlogImage>();
            CreateMap<BlogComment, BlogCommentViewModel>();
            CreateMap<BlogCommentViewModel, BlogComment>();
            CreateMap<BlogSlogan, BlogSloganViewModel>();
            CreateMap<BlogSloganViewModel, BlogSlogan>();

        }
    }
}
