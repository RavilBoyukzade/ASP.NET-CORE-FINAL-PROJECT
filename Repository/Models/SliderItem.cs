﻿using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class SliderItem : BaseEntity
    {
        public int OrderBy { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        [Required]
        [MaxLength(200)]
        public string Slogan { get; set; }
        [Required]
        [MaxLength(100)]
        public string Image { get; set; }
        [Required]
        [MaxLength(50)]
        public string ActionText { get; set; }
        [Required]
        [MaxLength(200)]
        public string EndPoint { get; set; }
    }
}
