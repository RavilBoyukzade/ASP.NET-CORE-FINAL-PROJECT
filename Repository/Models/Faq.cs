using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class Faq : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Question { get; set; }
        [Required]
        [MaxLength(200)]
        public string Answer { get; set; }
    }
}
