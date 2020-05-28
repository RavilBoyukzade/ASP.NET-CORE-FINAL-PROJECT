using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_CORE_FINAL_PROJECT.Controllers
{
    public class ContactController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}