using ASP.NET_CORE_FINAL_PROJECT.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ServiceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE_FINAL_PROJECT.ViewComponents
{
    public class BlogViewComponent :ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IServiceRepository _serviceRepository;

        public BlogViewComponent(IMapper mapper,IServiceRepository serviceRepostory)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepostory;
        }

        public IViewComponentResult Invoke() 
        {
            var service = _serviceRepository.GetServices();
            var model = _mapper.Map<IEnumerable<Service>, IEnumerable<ServiceViewModel>>(service);

            return View(model);
        }

    }
}
