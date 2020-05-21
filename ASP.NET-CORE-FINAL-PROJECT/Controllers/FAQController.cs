﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_CORE_FINAL_PROJECT.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.ContentRepository;

namespace ASP.NET_CORE_FINAL_PROJECT.Controllers
{
    public class FAQController : Controller
    {
        private readonly IContentRepository _contentRepository;

        public FAQController(IContentRepository contentRepository)
        {
            _contentRepository = contentRepository;
        }
        public IActionResult Index()
        {


            var model = new SettingViewModel
            {
                Settings = _contentRepository.GetSettings()
            };
            return View(model);
        }
    }
}