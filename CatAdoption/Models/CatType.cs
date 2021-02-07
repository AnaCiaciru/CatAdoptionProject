using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CatAdoption.Models
{
    public class CatType
    {
        public int Id { get; set; }
        public string Breed { get; set; }

        [MinLength(2, ErrorMessage = "Color cannot be less than 2!"),
        MaxLength(20, ErrorMessage = "Color cannot be more than 20!")]
        public string Color { get; set; }

        // many-to-one
        public virtual ICollection<Cat> Cats { get; set; }
    }
}