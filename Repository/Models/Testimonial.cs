using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class Testimonial : BaseEntity
    {
       
        [Required]
        [MaxLength(500)]
        public string Text { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Position { get; set; }

    }
}
