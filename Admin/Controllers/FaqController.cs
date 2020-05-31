using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models.Faq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.FAQ;

namespace Admin.Controllers
{
    public class FaqController : Controller
    {
        //[TypeFilter(typeof(Auth))]

        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IMapper _mapper;
        private readonly IFaqRepository _faqRepository;

        public FaqController(IFaqRepository faqRepository,IMapper mapper)
        {
            _mapper = mapper;
            _faqRepository = faqRepository;
        }
        public IActionResult Index()
        {
            var faq = _faqRepository.GetAllFaqs();
            var model = _mapper.Map<IEnumerable<Faq>, IEnumerable<FaqViewModel>>(faq);

            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FaqViewModel faq)
        {
            if (ModelState.IsValid)
            {
                Faq model = _mapper.Map<FaqViewModel, Faq>(faq);
                model.AddedBy = "System";
                _faqRepository.CreateFaq(model);
                return RedirectToAction("index");
            }
            return View(faq);
        }

        public IActionResult Update(int id)
        {
            Faq faq = _faqRepository.GetFaqById(id);
            if (faq == null) return NotFound();
            var model = _mapper.Map<Faq, FaqViewModel>(faq);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(FaqViewModel faq)
        {
            if (ModelState.IsValid)
            {
                Faq model = _mapper.Map<FaqViewModel, Faq>(faq);
                model.ModifiedBy = "System";
                model.ModifiedDate = DateTime.Now;
                Faq faqToUpdate = _faqRepository.GetFaqById(faq.Id);
                if (faqToUpdate == null) return NotFound();
                _faqRepository.UpdateFaq(faqToUpdate, model);
                return RedirectToAction("index");
            }
            return View(faq);
        }

        public IActionResult Delete(int id)
        {
            Faq faq = _faqRepository.GetFaqById(id);
            if (faq == null) return NotFound();
            _faqRepository.DeleteFaq(faq);
            return RedirectToAction("index");
        }
    }
}