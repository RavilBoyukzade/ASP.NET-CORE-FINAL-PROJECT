using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Service
{
    public class ServiceViewModel
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        [Required(ErrorMessage ="Adini yazmaq unutma")]
        [MaxLength(50, ErrorMessage = "Adinin uzunlugu 50 simvol ashmamalidir")]
        public string Name { get; set; }
        [Required(ErrorMessage = "logo Iconun adi")]
        public string Logo { get; set; }
        [Required(ErrorMessage = "Metni yazmaq unutma")]
        [MaxLength(500,ErrorMessage = "Maximal uzunluq 500 simvoldur")]
        public string Text { get; set; }

        [Required(ErrorMessage = "Slogan yazmaq unutma")]
        [MaxLength(200, ErrorMessage = "Sloganin uzunlugu 200 simvoldur")]
        public string Slogan { get; set; }
        [Required(ErrorMessage = "Tesviri yazmaqa unutma")]
        [MaxLength(200,ErrorMessage = "Tesvirin uzunlugu 200 simvoldur")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Shekili elave et")]
        public string Image { get; set; }
        [Required(ErrorMessage = "Hansi Linke kecid edeceyini geyd ele")]
        [MaxLength(200, ErrorMessage = "Maximal uzunluq 200 simvoldur")]
        public string EndPoint { get; set; }
    }
}
