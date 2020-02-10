using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KontraMIS4200.Models
{
    public class appointmentDetail
    {
        public int appointmentDetailId { get; set; }
        public DateTime dateTime { get; set; }

        // link to pet
        public int petId { get; set; }
        public virtual Pet Pet { get; set; }

        // link to vet
        public int vetId { get; set; }
        public virtual Vet Vet { get; set; }

    }
}