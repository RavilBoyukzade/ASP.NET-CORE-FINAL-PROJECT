using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class BestPlan:BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Icon { get; set; }

        public string OrderBy { get; set; }
        [Required]
        [MaxLength(50)]
        public string ActionText { get; set; }
        [Required]
        [MaxLength(100)]
        public string EndPoint { get; set; }
        [Required]
        [MaxLength(50)]
        public int? LabelId { get; set; }
        public Label Label { get; set; }

        public ICollection<BestPlanCateg> PlanCategs { get; set; }
    }
}
