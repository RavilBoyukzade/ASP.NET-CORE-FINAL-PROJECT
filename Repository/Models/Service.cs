using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class Service : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Logo { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        [Required]
        [MaxLength(100)]
        public string ShortDescription { get; set; }
        [Required]
        [MaxLength(200)]
        public string Text { get; set; }
        [Required]
        [MaxLength(100)]
        public string ShortText { get; set; }
        [Required]
        [MaxLength(50)]
        public string Image { get; set; }

        public ICollection<AboutCard> Cards  { get; set; }
    }
}
