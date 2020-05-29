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
        [Required]
        [MaxLength(50)]
        public string InsuranceProfile { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }
        [Required]
        [MaxLength(500)]
        public string Text { get; set; }
        public ICollection<CaseStudSpec> CaseStudSpecs  { get; set; }
        public ICollection<CaseStudCollapse> CaseStudCollapses  { get; set; }

    }
}
