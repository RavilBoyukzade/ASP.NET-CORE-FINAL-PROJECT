using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class AboutCard :BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Logo { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Text { get; set; }

        public AboutItem AboutItems { get; set; }
    }
}
