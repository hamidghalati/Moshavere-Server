using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Moshavere.Data.Models
{
   public class Type_advice:BaseEntity<string>
    {
        public Type_advice()
        {
            Id = Guid.NewGuid().ToString();
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }
        [Required]
        public string TAdvice { get; set; }
        public User User { get; set; }
        public string Description { get; set; }

    }
}
