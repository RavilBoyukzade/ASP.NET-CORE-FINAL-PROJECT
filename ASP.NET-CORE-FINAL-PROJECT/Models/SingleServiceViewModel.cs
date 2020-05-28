using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE_FINAL_PROJECT.Models
{
    public class SingleServiceViewModel
    {
        public IEnumerable<Service> Services { get; set; }
        public IEnumerable<ServiceSpec> ServiceSpecs { get; set; }

        public IEnumerable<ServiceItem> ServiceItems { get; set; }
    }
}
