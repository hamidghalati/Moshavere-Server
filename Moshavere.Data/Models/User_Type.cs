using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Moshavere.Data.Models
{
    public class User_Type : BaseEntity<string>
    {
        public User_Type()
        {
            Id = Guid.NewGuid().ToString();
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }
        [Required]
        public string Account_Type { get; set; }
        public string Description { get; set; }
        public ICollection<User> User { get; set; }

    }
}
