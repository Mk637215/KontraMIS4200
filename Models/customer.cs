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

        // Add other fields accordingly
        // a cust can have any number of orders, a 1:M relationship,
        // we rep thisi in the model w an ICollection
        // the syntax says we are creating an ICollection of order objects,
        // (the name inside the <> is the object name),
        // and the local name of the collection will be that Order
        // (the object name and the local name do not have to be the same)

        public ICollection<Order> Order { get; set; }

    }
}