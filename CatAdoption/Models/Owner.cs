using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CatAdoption.Models
{
    public class Owner
    {
        public int OwnerId { get; set; }
        public string Name { get; set; }

        // many-to-one relationship
        public virtual ICollection<Cat> Cats { get; set; }

        // one-to-one relationship
        [Required]
        public virtual ContactInfo ContactInfo { get; set; }
    }
}