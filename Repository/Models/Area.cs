using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Area : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string Text { get; set; }
        [Required]
        [MaxLength(50)]
        public string ActionText { get; set; }
        [Required]
        [MaxLength(100)]
        public string EndPoint { get; set; }
        [Required]
        [MaxLength(50)]
        public string Image { get; set; }
        [Required]
        [MaxLength(100)]
        public string VideoLink { get; set; }
        [Required]
        [MaxLength(50)]
        public string Count { get; set; }
        [Required]
        [MaxLength(50)]
        public string ImgTxt { get; set; }
        public ICollection<Setting> Settings { get; set; }
    }
}
