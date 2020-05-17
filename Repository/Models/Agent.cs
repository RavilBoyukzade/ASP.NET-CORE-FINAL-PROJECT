using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Repository.Models
{
    public class Agent :BaseEntity
    {
        public int OrderBy { get; set; }
        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(50)]
        public string Position { get; set; }
        [Required]
        [MaxLength(50)]
        public string Photo { get; set; }

        public ICollection<Setting> Settings { get; set; }
    }
}
