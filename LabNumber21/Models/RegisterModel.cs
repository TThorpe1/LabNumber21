using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabNumber21.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Enter First Name")]
        [DisplayName("First Name")]
        [MaxLength(20)]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Enter Last Name")]
        [DisplayName("Last Name")]
        [MaxLength(20)]
        public string LastName { get; set; }

        //[Required(ErrorMessage = "Enter Email")]
        //[DisplayName("Email")]
        //[DataType(DataType.EmailAddress)]
        //public double Email { get; set; }

        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Password")]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string PassWord { get; set; }

        

        


    }
}