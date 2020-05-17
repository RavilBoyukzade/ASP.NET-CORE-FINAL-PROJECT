using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class Testimonial : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string Text { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Position { get; set; }

    }
}
