using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE_FINAL_PROJECT.Models
{
    public class AboutViewModel
    {
        public int SettingId { get; set; }
        
        public string Title { get; set; }
        
        public string EndPoint { get; set; }
        
        public string ActionText { get; set; }
       
        public string Description { get; set; }
        
        public string Text { get; set; }
        
        public string InformText { get; set; }
       
        public string Image { get; set; }

        public SettingViewModel Setting  { get; set; }
        public AboutCardViewModel AboutCard { get; set; }
    }
}
