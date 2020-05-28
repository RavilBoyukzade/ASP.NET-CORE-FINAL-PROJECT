using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ServiceRepository
{
    public interface IServiceRepository
    {
        IEnumerable<Service> GetServices();
        Blog GetBlogById(int id);

        void PostBlogComment(BlogComment comment);

    }

    public class ServiceRepository : IServiceRepository
    {
        private readonly JotexDbContext _context;

        public ServiceRepository(JotexDbContext context)
        {
            _context = context;
        }

        Blog IServiceRepository.GetBlogById(int id)
        {
            return _context.Blogs.Include("BlogComments")
                                 .Include("BlogSlogans")
                                 .Include("BlogImages").FirstOrDefault(b => b.Id == id);
        }

        public IEnumerable<Blog> GetBlogById(int id)
        {
            return _context.Blogs.Include("BlogComments")
                                 .Include("BlogSlogans")
                                 .Include("BlogImages")
                                 .Where(b => b.Id == id)
                                 .Where(s => s.Status);
        }

       
        public IEnumerable<Service> GetServices()
        {
            return _context.Services.Include("Blogs")
                                    .Include("Blogs.BlogImages")
                                    .Include("ServiceSpecs")
                                    .Where(s => s.Status)
                                    .ToList();
        }

        public void PostBlogComment(BlogComment comment)
        {
            _context.BlogComments.Add(comment);
            _context.SaveChanges();
        }
    }
}
