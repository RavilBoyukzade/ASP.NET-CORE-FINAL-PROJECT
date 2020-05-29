using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace ASP.NET_CORE_FINAL_PROJECT.Models
{
    public class CaseStudViewModel
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Insurance { get; set; }
        public string InsuranceProfile { get; set; }
        public string Title { get; set; }
       
        public string Description { get; set; }
        
        public string Text { get; set; }

        public List<CaseStudSpec> StudSpecs { get; set; }
        public List<CaseStudCollapse> StudCollapses { get; set; }

    }
}
