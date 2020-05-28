﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE_FINAL_PROJECT.Models
{
    public class ServiceViewModel
    {
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Text { get; set; }
        public string Slogan { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string EndPoint { get; set; }
        public List<BlogViewModel> Blogs { get; set; }
    }
}
