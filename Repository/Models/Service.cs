using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Repository.Models
{
    public class Service : BaseEntity
    {  

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public string Logo { get; set; }
        [Required]
        [MaxLength(500)]
        public string Text { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string Slogan { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        [MaxLength(200)]
        public string EndPoint { get; set; }
        public ICollection<ServiceItem> ServiceItem { get; set; }
        public ICollection<ServiceSpec> ServiceSpecs { get; set; }
        public ICollection<Blog> Blogs { get; set; }

    }
}
