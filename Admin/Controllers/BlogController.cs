using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models.Blog;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.BlogRepository;
using Repository.Repositories.ServiceRepository;

namespace Admin.Controllers
{
    public class BlogController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IMapper _mapper;
        private readonly IBlogRepository _blogRepository;
        private readonly IServiceRepository _serviceRepository;
        public BlogController(IMapper mapper,
                              IBlogRepository blogRepository,
                              IServiceRepository serviceRepository)
        {
            _mapper = mapper;
            _blogRepository = blogRepository;
            _serviceRepository = serviceRepository;
        }
        public IActionResult Index()
        {
            var blogs = _blogRepository.GetBlogs();
            var model = _mapper.Map<IEnumerable<Blog>, IEnumerable<BlogViewModel>>(blogs);
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.Services = _serviceRepository.GetServices();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BlogViewModel blog)
        {
            if (ModelState.IsValid)
            {
                Blog model = _mapper.Map<BlogViewModel, Blog>(blog);
                model.AddedBy = "System";
                _blogRepository.CreateBlog(model);
                return RedirectToAction("index");
            }
            ViewBag.Services = _serviceRepository.GetServices();
            return View(blog);
        }
        public IActionResult Edit(int id)
        {
            Blog blog = _blogRepository.GetBlogById(id);
            if (blog == null) return NotFound();
            var model = _mapper.Map<Blog, BlogViewModel>(blog);
            ViewBag.Services = _serviceRepository.GetServices();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BlogViewModel model)
        {
            if (ModelState.IsValid)
            {
                Blog blog = _mapper.Map<BlogViewModel, Blog>(model);
                blog.AddedBy = "System";
                Blog blogToUpdate = _blogRepository.GetBlogById(blog.Id);
                if (blogToUpdate == null) return NotFound();
                _blogRepository.UpdateFag(blogToUpdate, blog);
                return RedirectToAction("index");
            }
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            Blog blog = _blogRepository.GetBlogById(id);
            if (blog == null) return NotFound();
            _blogRepository.DeleteBlog(blog);
            return RedirectToAction("index");
        }
    }
}
