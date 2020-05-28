
using ASP.NET_CORE_FINAL_PROJECT.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepository;
using Repository.Repositories.ServiceRepository;
using System.Collections.Generic;

namespace ASP.NET_CORE_FINAL_PROJECT.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContentRepository _contentRepository;
        public HomeController(IContentRepository contentRepository)
        {
            _contentRepository = contentRepository;
        }


        public IActionResult Index()
        {
            var model = new BaseViewModel
            {
                Setting = _contentRepository.GetSettings()
        };

            return View(model);
        }
    }
}