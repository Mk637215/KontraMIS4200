using KontraMIS4200.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KontraMIS4200.Models
{
    public class Pet
    {
        public int petId { get; set; }

        [Display (Name = " Pet's Name")]
        [Required(ErrorMessage = "Pet's name is required")]
        [StringLength(20)]
        public string name { get; set; }
        [Display (Name = "Pet's Gender")]
        [Required(ErrorMessage = "Pet's gender is required")]
        [StringLength(20)]
        public string gender { get; set; }
        [Display (Name = "Pet's Species")]
        [Required(ErrorMessage = "Pet's species is required")]
        [StringLength(20)]
        public string species { get; set; }
        public ICollection<appointmentDetail> appointmentDetail { get; set; }

        public int vetId { get; set; }
       // public virtual Vet Vet { get; set; }

    }
}