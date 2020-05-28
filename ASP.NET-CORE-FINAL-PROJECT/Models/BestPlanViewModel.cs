using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE_FINAL_PROJECT.Models
{
    public class BestPlanViewModel
    {
      
        public string Name { get; set; }
        
        public string Icon { get; set; }

        public string OrderBy { get; set; }
        
        public string ActionText { get; set; }
       
        public string EndPoint { get; set; }
        public List<BestPlanCategViewModel> PlanCateg { get; set; }

    }
}
