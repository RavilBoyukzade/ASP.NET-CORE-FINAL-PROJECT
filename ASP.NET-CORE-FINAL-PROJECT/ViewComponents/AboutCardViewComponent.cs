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
    public class AboutCardViewComponent :ViewComponent
    {
        private readonly IMapper _mapper;
        private IAboutRepository _aboutRepository;

        public AboutCardViewComponent(IMapper mapper,IAboutRepository aboutRepository)
        {
            _mapper = mapper; ;
            _aboutRepository = aboutRepository;
        }
        public IViewComponentResult Invoke()
        {
            var card = _aboutRepository.GetCards();
            var model = _mapper.Map<IEnumerable<AboutCard>,IEnumerable<AboutCardViewModel>>(card);

            return View(model);

        }
    }
}
