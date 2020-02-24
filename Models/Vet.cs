using KontraMIS4200.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KontraMIS4200.Models
{
    public class Vet
    {
        public int vetId { get; set; }
        [Display(Name = "Vet First Name")]
        [Required(ErrorMessage = "Vet first name is required")]
        [StringLength(20)]
        public string firstName { get; set; }
        [Display(Name = "Vet Last Name")]
        [Required(ErrorMessage = "Vet last name is required")]
        [StringLength(20)]
        public string lastName { get; set; }
        [Display (Name = "Years of Experience")]
        [Required(ErrorMessage = "Vet's year(s) of experience is required")]
        [StringLength(20)]
        public string yearsOfExperience { get; set; }
        public ICollection<appointmentDetail> appointmentDetail { get; set; }
        public string FullName
        {
            get { return lastName + firstName; }
        }




    }
}