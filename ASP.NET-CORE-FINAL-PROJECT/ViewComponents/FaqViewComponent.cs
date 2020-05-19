using ASP.NET_CORE_FINAL_PROJECT.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.FAQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE_FINAL_PROJECT.ViewComponents
{
    public class FaqViewComponent :ViewComponent
    {
        private IMapper _mapper;
        private IFaqRepository _faqRepository;

        public FaqViewComponent(IMapper mapper,
                                IFaqRepository faqRepository)
        {
            _mapper = mapper;
            _faqRepository = faqRepository;
        }

        public IViewComponentResult Invoke()
        {
            var faq = _faqRepository.GetFaqs();

            var model = _mapper.Map<IEnumerable<Faq>, IEnumerable<FaqViewModel>>(faq);

            return View(model);
        }
    }
}
