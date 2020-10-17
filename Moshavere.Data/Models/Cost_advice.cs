using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Moshavere.Data.Models
{
   public class Cost_advice:BaseEntity<string>
    {
        public Cost_advice()
        {
            Id = Guid.NewGuid().ToString();
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }

        public ICollection<Type_advice> Type_Advices { get; set; }
        [Required]
        public int Times { get; set; }
        [Required]
        public string Price { get; set; }

    }
}
