using ASP.NET_CORE_FINAL_PROJECT.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.AboutRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE_FINAL_PROJECT.ViewComponents
{
    public class HomeAboutViewComponent:ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IAboutRepository _aboutRepository;

        public HomeAboutViewComponent(IMapper mapper,
                                  IAboutRepository aboutRepository)
        {
            _mapper = mapper;
            _aboutRepository = aboutRepository;
        }

        public IViewComponentResult Invoke()
        {
            var homeAbout = _aboutRepository.GetAboutUs();

            var model = _mapper.Map<IEnumerable<AboutItem>, IEnumerable<AboutViewModel>>(homeAbout);

            return View(model);
        }
    }

}
