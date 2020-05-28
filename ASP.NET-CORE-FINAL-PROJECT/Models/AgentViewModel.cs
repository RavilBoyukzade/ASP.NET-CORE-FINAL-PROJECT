using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE_FINAL_PROJECT.Models
{
    public class AgentViewModel
    {
        public string FullName { get; set; }
      
        public string Position { get; set; }
        
        public string Photo { get; set; }
        public SettingViewModel Setting { get; set; }
    }
}
