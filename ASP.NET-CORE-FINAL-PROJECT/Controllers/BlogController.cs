using ASP.NET_CORE_FINAL_PROJECT.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepository;
using Repository.Repositories.ServiceRepository;
using System;

namespace ASP.NET_CORE_FINAL_PROJECT.Controllers
{
    public class BlogController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IServiceRepository _serviceRepository;
        private readonly IContentRepository _contentRepository;
        
        public BlogController(IMapper mapper,
                              IServiceRepository serviceRepository,
                              IContentRepository contentRepository)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
            _contentRepository = contentRepository;
        }
        
        public IActionResult Index()
        {
            var baseView = new BaseViewModel
            {
                Setting = _contentRepository.GetSettings()
            };
            return View(baseView);
        }

        public IActionResult BlogSingle(int id)
        {
            var blog = _serviceRepository.GetBlogById(id);

            if (blog == null) return NotFound();

            var model = _mapper.Map<Blog, BlogViewModel>(blog);

            return View(model);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult BlogSingle(BlogViewModel Comment)
        {
            BlogComment blogComment = new BlogComment
            {
                ModifiedDate = DateTime.Now,
                Status = true,
                AddedDate = DateTime.Now,
                AddedBy = Comment.BlogComments[0].Name,
                ModifiedBy = Comment.BlogComments[0].Name,
                Name = Comment.BlogComments[0].Name,
                Text = Comment.BlogComments[0].Text,
                BlogId = Comment.BlogComments[0].BlogId,
                Image = "#"
            };

             _serviceRepository.PostBlogComment(blogComment);

            var blog = _serviceRepository.GetBlogById(Comment.BlogComments[0].BlogId);

            if (blog == null) return NotFound();

            var model = _mapper.Map<Blog, BlogViewModel>(blog);

            return View(model);
        }


    }

    
}