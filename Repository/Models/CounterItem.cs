using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Authentication.ExtendedProtection;
using System.Text;

namespace Repository.Models
{
    public class CounterItem :BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Logo { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Text { get; set; }
        [Required]
        [MaxLength(100)]
        public string EndPoint { get; set; }
        [Required]
        [MaxLength(50)]
        public string ActionText { get; set; }
        public AboutItem AboutItem { get; set; }
    }
}
