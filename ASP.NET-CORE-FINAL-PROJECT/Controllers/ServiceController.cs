using ASP.NET_CORE_FINAL_PROJECT.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.ServiceRepository;

namespace ASP.NET_CORE_FINAL_PROJECT.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
        public IActionResult Index()
        {
            var sservice = new SingleServiceViewModel
            {
                Services = _serviceRepository.GetServices()
            };



            return View(sservice);
        }
    }
}