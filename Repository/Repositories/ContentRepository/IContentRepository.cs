using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.ContentRepository
{
    public interface IContentRepository
    {
        IEnumerable<SliderItem> GetSliderItems();
        IEnumerable<Brand> GetBrands();
        IEnumerable<Testimonial> GetTestimonials();

        Setting GetSettings();
    }
}
