using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Faq
{
    public class FaqViewModel
    {
        public int Id { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required(ErrorMessage ="Sual vermeyi unutma!")]
        [MaxLength(500,ErrorMessage ="Metinin uzunluqu 500 simvola gederdi!")]
        public string Question { get; set; }
        [Required(ErrorMessage = "Cavab vermeyi unutma!")]
        [MaxLength(500, ErrorMessage = "Metinin uzunluqu 500 simvola gederdi!")]
        public string Answer { get; set; }
    }
}
