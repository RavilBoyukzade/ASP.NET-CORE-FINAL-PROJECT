using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_CORE_FINAL_PROJECT.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_CORE_FINAL_PROJECT.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
    }
}