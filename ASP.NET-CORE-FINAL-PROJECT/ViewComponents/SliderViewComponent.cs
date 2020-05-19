using ASP.NET_CORE_FINAL_PROJECT.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE_FINAL_PROJECT.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;

        public SliderViewComponent(IMapper mapper,
                                   IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;
        }

        public IViewComponentResult Invoke()
        {
            var sliderItems = _contentRepository.GetSliderItems();

            var model = _mapper.Map<IEnumerable<SliderItem>, IEnumerable<SliderItemViewModel>>(sliderItems);

            return View(model);
        }
    }
}
