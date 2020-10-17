using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Moshavere.Data.Dtos.Site.Admin
{
    public class UserForRegisterDto
    {
        [Required]
        [EmailAddress(ErrorMessage = "ایمیل را به صورت صحیح وارد نمایید")]
        public string UserName { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "کلمه عبور باید بین 4 تا 12 کاراکتر باشد")]
        public string Password { get; set; }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
