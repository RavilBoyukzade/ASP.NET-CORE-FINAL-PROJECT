﻿using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ContentRepository
{
    public class ContentRepository : IContentRepository
    {
        private readonly JotexDbContext _context;

        public ContentRepository(JotexDbContext context)
        {
            _context = context;
        }

       

        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brands.OrderByDescending(b => b.AddedDate).ToList();
        }

        public Setting GetSettings()
        {
            return _context.Settings.Where(s => s.Status).FirstOrDefault();
        }

        public IEnumerable<SliderItem> GetSliderItems()
        {
            return _context.SliderItems.Where(s => s.Status)
                                       .OrderBy(s => s.OrderBy)
                                       .ToList();
        }

        public IEnumerable<Testimonial> GetTestimonials()
        {
            return _context.Testimonials.OrderByDescending(t => t.AddedDate).ToList();
        }
    }
}
