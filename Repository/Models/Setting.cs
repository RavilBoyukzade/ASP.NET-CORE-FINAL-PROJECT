using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Repository.Models
{
   public class Setting : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Logo { get; set; }
        [Required]
        [MaxLength(100)]
        public string Adress { get; set; }
        [Required]
        [MaxLength(50)]
        public string WorkTime { get; set; }
        [Required]
        [MaxLength(50)]
        public string NeedHelpNumber { get; set; }
        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        [Required]
        [MaxLength(50)]
        public string OfficeTime { get; set; } 


        public Agent Agent { get; set; }
        public AboutItem AboutItem { get; set; }
        public ICollection<SocialMedia> Medias { get; set; }
       
    }
}
