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
        IEnumerable<CaseStud> GetStuds();
    }

    public class CaseRepository : ICaseRepository
    {
        private readonly JotexDbContext _context;

        public CaseRepository(JotexDbContext context)
        {
            _context = context;
        }
        public IEnumerable<CaseStud> GetStuds()
        {
            return _context.CaseStuds.Where(c => c.Status)
                                     .ToList();
        }
    }
}
