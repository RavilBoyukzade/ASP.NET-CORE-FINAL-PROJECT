using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Repository.Models
{
   public class Setting : BaseEntity
    {
        [Required]
        public string Logo { get; set; }
        [Required]
        public string FooterLogo { get; set; }
        [Required]
        public string BalckLogo { get; set; }
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

        public IEnumerable<AboutItem> AboutItems { get; set; }
        public ICollection<SocialMedia> SocialMedias { get; set; }

    }
}
