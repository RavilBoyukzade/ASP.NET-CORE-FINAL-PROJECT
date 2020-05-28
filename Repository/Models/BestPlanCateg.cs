using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class BestPlanCateg:BaseEntity
    {
        public int BestPlanId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public BestPlan BestPlan { get; set; }
    }
}
