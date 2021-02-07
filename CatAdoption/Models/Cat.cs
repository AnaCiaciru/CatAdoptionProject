using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CatAdoption.Models
{
    public class Cat
    {
        public int CatId { get; set; }
        [MinLength(2, ErrorMessage = "Name cannot be less than 2!"),
            MaxLength(200, ErrorMessage = "Name cannot be more than 200!")]
        public string Name { get; set; }
        public Gender Gender { get; set; }

        [MinLength(2, ErrorMessage = "Description cannot be less than 2!"),
        MaxLength(5000, ErrorMessage = "Description cannot be more than 5000!")]
        public string Description { get; set; }
        public int Age { get; set; }    
        public DateTime DateOfJoining { get; set; }

        // one-to-many relationship
        public Owner OwnerId { get; set; }
        public virtual Owner Owner { get; set; }

        // one-to-many relationship
        public CatType CatTypeId { get; set; }
        public virtual CatType CatType { get; set; }

        // many-to-many relationship
        public virtual ICollection<Characteristic> Characteristics { get; set; }

        // dropdown lists
        public IEnumerable<SelectListItem> CatTypeList { get; set; }
        public IEnumerable<SelectListItem> OwnerList { get; set; }

        // checkboxes list
        [NotMapped]
        public List<CheckBoxViewModel> CharacteristicsList { get; set; }

    }
}