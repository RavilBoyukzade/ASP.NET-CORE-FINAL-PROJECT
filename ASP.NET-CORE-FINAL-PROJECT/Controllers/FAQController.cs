using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_CORE_FINAL_PROJECT.Controllers
{
    public class FAQController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}