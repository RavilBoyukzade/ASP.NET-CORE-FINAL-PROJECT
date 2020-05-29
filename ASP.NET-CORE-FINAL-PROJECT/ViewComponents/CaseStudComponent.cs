using ASP.NET_CORE_FINAL_PROJECT.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.CaseStudRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE_FINAL_PROJECT.ViewComponents
{
    public class CaseStudComponent:ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly ICaseRepository _caseRepository;

        public CaseStudComponent(IMapper mapper,ICaseRepository caseRepository)
        {
            _mapper = mapper;
            _caseRepository = caseRepository;
        }

        public IViewComponentResult Invoke()
        {
            var stud = _caseRepository.GetCaseStuds();

            var model = _mapper.Map<IEnumerable<CaseStud>, IEnumerable<CaseStudViewModel>>(stud);

            return View(model);
        }
    }
}
