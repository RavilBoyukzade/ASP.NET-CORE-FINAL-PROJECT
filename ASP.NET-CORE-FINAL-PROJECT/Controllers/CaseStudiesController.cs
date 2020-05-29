using ASP.NET_CORE_FINAL_PROJECT.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.CaseStudRepository;
using System.Collections.Generic;

namespace ASP.NET_CORE_FINAL_PROJECT.Controllers
{
    public class CaseStudiesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICaseRepository _caseRepository;

        public CaseStudiesController(IMapper mapper,
                                     ICaseRepository caseRepository)
        {
            _mapper = mapper;
            _caseRepository = caseRepository;
        }

        
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult CaseSingle(int id)
        {
            var studies = _caseRepository.GetCaseById(id);
            if (studies == null) return NotFound();
            var model = _mapper.Map<CaseStud, CaseStudViewModel>(studies);

            return View(model);
        }
    }

    
        
    
}