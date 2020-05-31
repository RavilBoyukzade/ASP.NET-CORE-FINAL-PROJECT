using Admin.Models.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Blog
{
    public class BlogViewModel
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public int ServiceId { get; set; }
        [Required(ErrorMessage = "Başlıqı yaz")]
        [MaxLength(50, ErrorMessage = "Başlıq uzunluğu 50 simvoldur")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Mətn yaz")]
        [MaxLength(500, ErrorMessage = "Mətn uzunluğu 500 simvoldur")]
        public string Text { get; set; }
        [Required(ErrorMessage = "Digər Başlıq yaz")]
        [MaxLength(50, ErrorMessage = "Digər Başlıq uzunluğu 50 simvoldur")]
        public string Subtitle { get; set; }
        [Required(ErrorMessage = "Digər mətn yaz")]
        [MaxLength(500, ErrorMessage = "Digər mətn uzunluğu 500 simvoldur")]
        public string Subtext { get; set; }
        [Required(ErrorMessage = "knopkanin textini yaz")]
        [MaxLength(50, ErrorMessage = "knopkanin textinin uzunluğu 50 simvoldur")]
        public string ActionText { get; set; }
        public ServiceViewModel Service { get; set; }
    }
}
