using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class CaseStudSpec:BaseEntity
    {
        public int OrderBy { get; set; }
        public int CaseStudId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Key { get; set; }

        [Required]
        [MaxLength(500)]
        public string Value { get; set; }
    }
}
