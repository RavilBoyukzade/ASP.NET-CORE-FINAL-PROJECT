using Microsoft.EntityFrameworkCore;
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

        public Testimonial CreateTestimonial(Testimonial model)
        {
            model.AddedDate = DateTime.Now;
            _context.Testimonials.Add(model);
            _context.SaveChanges();
            return model;
        }

        public void DeleteTestimonial(Testimonial testimonial)
        {
            _context.Remove(testimonial);
            _context.SaveChanges();
        }

        public IEnumerable<Testimonial> GetAllTestimonials()
        {
            return _context.Testimonials.ToList();
        }

        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brands.OrderByDescending(b => b.AddedDate).ToList();
        }

        

        public IEnumerable<Area> GetLikebleArea()
        {
            return _context.Areas.Where(a => a.Status)
                                 .ToList();
        }

        public IEnumerable<BestPlan> GetPlans()
        {
            return _context.BestPlans.Include(m=>m.PlanCategs)
                                     .Where(p => p.Status)
                                     .ToList();
        }

        public Setting GetSettings()
        {
            return _context.Settings/*.Include("SocialMedias")*/
                                    .Where(s => s.Status)
                                    .FirstOrDefault();
        }

        public IEnumerable<SliderItem> GetSliderItems()
        {
            return _context.SliderItems.Where(s => s.Status)
                                       .OrderBy(s => s.OrderBy)
                                       .ToList();
        }

        public Testimonial GetTestimonialById(int id)
        {
            return _context.Testimonials.Find(id);
        }

        public IEnumerable<Testimonial> GetTestimonials()
        {
            return _context.Testimonials.Where(s=>s.Status)
                                        .OrderByDescending(t => t.AddedDate)
                                        .ToList();
        }

        public void UpdateTestimonial(Testimonial TestimonialToUpdate, Testimonial model)
        {
            TestimonialToUpdate.Status = model.Status;
            TestimonialToUpdate.Text = model.Text;
            TestimonialToUpdate.Name = model.Name;
            TestimonialToUpdate.Position = model.Position;
            TestimonialToUpdate.ModifiedBy = model.ModifiedBy;
            TestimonialToUpdate.ModifiedDate = model.ModifiedDate;

            _context.SaveChanges();
        }
    }
}
