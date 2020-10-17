﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Moshavere.Data.Models
{
    public class Photo : BaseEntity<string>
    {
        public Photo()
        {
            Id = Guid.NewGuid().ToString();
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }
        public string Url { get; set; }

        public string Description { get; set; }
        [Required]
        public string IsMain { get; set; }
        [Required]
        public string UserId { get; set; }
        public User User { get; set; }
        public string Alt { get; set; }
    }
}
