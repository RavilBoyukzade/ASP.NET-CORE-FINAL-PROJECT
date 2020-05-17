using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class CaseStud:BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Image { get; set; }
        [Required]
        [MaxLength(50)]
        public string Insurance { get; set; }

    }
}
