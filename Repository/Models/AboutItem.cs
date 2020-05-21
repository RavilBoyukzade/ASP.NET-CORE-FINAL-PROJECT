using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Repository.Models
{
    public class AboutItem :BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string EndPoint { get; set; }
        [Required]
        [MaxLength(50)]
        public string ActionText { get; set; }
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }
        [Required]
        [MaxLength(200)]
        public string Text { get; set; }
        [Required]
        [MaxLength(100)]
        public string InformText { get; set; }
        [Required]
        [MaxLength(50)]
        public string Image { get; set; }

        public ICollection<CounterItem> Counters { get; set; }
    }
}
