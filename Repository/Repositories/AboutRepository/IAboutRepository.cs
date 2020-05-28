using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AboutRepository
{
    public interface IAboutRepository
    {
        IEnumerable<AboutItem> GetAboutUs();
        IEnumerable<AboutCard> GetCards();
    }


    public class AboutRepository :IAboutRepository
    {
        private readonly JotexDbContext _context;

        public AboutRepository(JotexDbContext context)
        {
            _context = context;
        }


        public IEnumerable<AboutItem> GetAboutUs()
        {
            return _context.AboutItems.Include("Setting")
                                      .Where(a => a.Status)                                  
                                      .ToList();
        }

        public IEnumerable<AboutCard> GetCards()
        {
            return _context.AboutCards.Where(c => c.Status)
                                      .ToList();
        }
    }
}
