﻿using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE_FINAL_PROJECT.Models
{
    public class BaseViewModel
    {
        public Setting Setting { get; set; }
        public SocialMedia Media { get; set; }
    }
}
