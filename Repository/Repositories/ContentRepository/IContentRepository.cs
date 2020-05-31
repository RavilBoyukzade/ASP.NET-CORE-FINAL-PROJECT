using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.ContentRepository
{
    public interface IContentRepository
    {   
        //Slider
        IEnumerable<SliderItem> GetSliderItems();

        //Brands
        IEnumerable<Brand> GetBrands();

        //Testimonial
        IEnumerable<Testimonial> GetTestimonials();
        IEnumerable<Testimonial> GetAllTestimonials();
        Testimonial CreateTestimonial(Testimonial model);
        Testimonial GetTestimonialById(int id);
        void UpdateTestimonial(Testimonial TestimonialToUpdate, Testimonial model);
        void DeleteTestimonial(Testimonial testimonial);
        //Areas
        IEnumerable<Area> GetLikebleArea();
        //Plans
        IEnumerable<BestPlan> GetPlans();
        //Settings
        Setting GetSettings();
    }
}
