using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Please Write You Email")]
        [EmailAddress(ErrorMessage ="Please Write Current Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please Write Your Password")]
        [MinLength(6,ErrorMessage = "Your password must be have at least 6 characters long")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
