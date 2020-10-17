using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Moshavere.Data.Dtos.Site.Admin
{
   public class UserForLoginDto
    {
        [Required]
        [EmailAddress(ErrorMessage = "ایمیل را به صورت صحیح وارد نمایید")]
        public string UserName { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 4)]
        public string Password { get; set; }
        public bool IsRemember { get; set; }
    }
}
