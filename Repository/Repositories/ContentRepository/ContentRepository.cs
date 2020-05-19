using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ContentRepository
{
    public class ContentRepository : IContentRepository
    {
        private readonly JotexDbContext _context;

        public ContentRepository(JotexDbContext context)
        {
            _context = context;
        }

        public IEnumerable<SliderItem> GetSliderItems()
        {
            return _context.SliderItems.Where(s => s.Status)
                                       .OrderBy(s => s.OrderBy)
                                       .ToList();
        }
    }
}
