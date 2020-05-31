using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Admin.Models.Testimonial;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepository;

namespace Admin.Controllers
{
    public class TestimonialController : Controller
    {
        //[TypeFilter(typeof(Auth))]

        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;

        public TestimonialController(IMapper mapper,
                                     IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;
        }
        public IActionResult Index()
        {
            var testimonal = _contentRepository.GetAllTestimonials();
            var model = _mapper.Map<IEnumerable<Testimonial>, IEnumerable<TestimonialViewModel>>(testimonal);

            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(TestimonialViewModel testimonial)
        {
            if (ModelState.IsValid)
            {
                Testimonial model = _mapper.Map<TestimonialViewModel, Testimonial>(testimonial);
                model.AddedBy = "System";
                _contentRepository.CreateTestimonial(model);
                return RedirectToAction("index");
            }
            return View(testimonial);
        }

        public IActionResult Update(int id)
        {
            Testimonial testimonial = _contentRepository.GetTestimonialById(id);
            if (testimonial == null) return NotFound();
            var model = _mapper.Map<Testimonial, TestimonialViewModel>(testimonial);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(TestimonialViewModel testimonial)
        {
            if (ModelState.IsValid)
            {
                Testimonial model = _mapper.Map<TestimonialViewModel, Testimonial>(testimonial);
                model.ModifiedBy = "System";
                model.ModifiedDate = DateTime.Now;
                Testimonial testimonialToUpdate = _contentRepository.GetTestimonialById(testimonial.Id);
                if (testimonialToUpdate == null) return NotFound();
                _contentRepository.UpdateTestimonial(testimonialToUpdate, model);
                return RedirectToAction("index");
            }
            return View(testimonial);
        }

        public IActionResult Delete(int id)
        {
            Testimonial testimonial = _contentRepository.GetTestimonialById(id);
            if (testimonial == null) return NotFound();
            _contentRepository.DeleteTestimonial(testimonial);
            return RedirectToAction("index");

        }
    }
}