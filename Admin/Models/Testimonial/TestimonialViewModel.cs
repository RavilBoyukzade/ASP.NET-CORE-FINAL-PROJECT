using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Testimonial
{
    public class TestimonialViewModel
    {
        public int Id { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required(ErrorMessage ="Mətn yazmağa vacibdi!")]
        [MaxLength(500,ErrorMessage ="Simvollarin uzunluğu 500-dən cox olmamalidir!")]
        public string Text { get; set; }
        [Required(ErrorMessage = "Adını yazmağa vacibdi!")]
        [MaxLength(100, ErrorMessage = "Simvollarin uzunluğu 100-dən cox olmamalidir!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "İş yerini yazmağa vacibdi!")]
        [MaxLength(100, ErrorMessage = "Simvollarin uzunluğu 100-dən cox olmamalidir!")]
        public string Position { get; set; }
    }
}
