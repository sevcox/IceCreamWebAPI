using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCream.Data
{
    //customeraddress.Customer.FirstName

    // Customers
    // CustomerId         FirstName      LastName
    //     1               Severa         Cox
    //     2               Erick         Forson

    // CustomerAddresses
    // CustomerAddressID     StreetOne             StreetTwo
    //     1                1234 Main Street         Apt 30

    public class CustomerAddress
    {
        [ForeignKey("Customer")]
        public int CustomerAddressID { get; set; }
        public virtual Customer Customer { get; set; }
        public string StreetOne { get; set; }
        public string StreetTwo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
