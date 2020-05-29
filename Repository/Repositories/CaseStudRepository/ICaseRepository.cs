using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.CaseStudRepository
{
    public interface ICaseRepository
    {
        IEnumerable<CaseStud> GetCaseStuds();
        CaseStud GetCaseById(int id);
    }

    public class CaseRepository : ICaseRepository
    {
        private readonly JotexDbContext _context;

        public CaseRepository(JotexDbContext context)
        {
            _context = context;
        }

        public CaseStud GetCaseById(int id)
        {
            return _context.CaseStuds.Include("CaseStudSpecs")
                                      .Include("CaseStudCollapses").FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<CaseStud> GetCaseStuds()
        {
            return _context.CaseStuds.Include("CaseStudSpecs")
                                      .Include("CaseStudCollapses")
                                      .Where(c => c.Status).ToList();
        }
    }
}
