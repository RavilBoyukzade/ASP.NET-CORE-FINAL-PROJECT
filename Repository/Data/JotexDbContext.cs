using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public class JotexDbContext:DbContext
    {
        public JotexDbContext(DbContextOptions<JotexDbContext> options) : base(options) { }


        public DbSet<AboutCard> AboutCards { get; set; }
        public DbSet<AboutItem> AboutItems { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<BestPlan> BestPlans { get; set; }
        public DbSet<CaseStud> CaseStuds { get; set; }
        public DbSet<CaseStudSpec> CaseStudSpecs { get; set; }
        public DbSet<CounterItem> CounterItems { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<Label> Labeles { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceSpec> ServiceSpecs { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial>Testimonials { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
