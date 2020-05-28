using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Repository.Models
{
    public class AboutItem :BaseEntity
    {
        public int SettingId { get; set; }
        [Required]
        [MaxLength(500)]
        public string Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string EndPoint { get; set; }
        [Required]
        [MaxLength(50)]
        public string ActionText { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        [MaxLength(500)]
        public string Text { get; set; }
        [Required]
        [MaxLength(500)]
        public string InformText { get; set; }
        [Required]
        [MaxLength(50)]
        public string Image { get; set; }
        public Setting Setting { get; set; }

    }
}
