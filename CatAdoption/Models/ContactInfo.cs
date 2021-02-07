using CatAdoption.Models.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CatAdoption.Models
{
    [Table("Contacts")]
    public class ContactInfo
    {
        public int ContactInfoId { get; set; }

        [RegularExpression(@"^07(\d{8})$", ErrorMessage = "This is not a valid phone number!")]
        public string PhoneNumber { get; set; }
        
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "This is not a valid phone number!")]
        public string Email { get; set; }

        [CNPValidator]
        public string CNP { get; set; }

        [Required, RegularExpression(@"^[1-9](\d{3})$", ErrorMessage = "This is not a valid year!")]
        public int BirthYear { get; set; }

        [Required, RegularExpression(@"^(0[1-9])|(1[012])$", ErrorMessage = "This is not a valid month!")]
        public string BirthMonth { get; set; }

        [Required, RegularExpression(@"^((0[1-9])|([12]\d)|(3[01]))$", ErrorMessage = "This is not a valid day number!")]
        public string BirthDay { get; set; }

        [Required]
        public Gender GenderType { get; set; }

        public bool Resident { get; set; }

        //one-to-many
        public int RegionId { get; set; }
        public Region Region { get; set; }
   

        // one-to one-relationship
        public virtual Owner Owner { get; set; }
    }
    public enum Gender
    {
        Male,
        Female
    }
}