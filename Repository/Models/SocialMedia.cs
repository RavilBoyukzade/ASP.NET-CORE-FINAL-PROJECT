﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class SocialMedia
    {
       
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Icon { get; set; }
        [Required]
        [MaxLength(100)]
        public string Link { get; set; }

        public Setting Setting { get; set; }

    }
}
