using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KontraMIS4200.Models
{
    public class customer
    {
        public int customerId { get; set; }
        public string customerLastName { get; set; }
        public string customerFirstName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime customerSince { get; set; }
    }
}