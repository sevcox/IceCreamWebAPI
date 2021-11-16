using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCream.Data
{
    // OrderFlavors
    // OrderID       FlavorID
    //  1                2
    //  123              5
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Flavor> ListOfFlavors { get; set; }

        public Order()
        {
            ListOfFlavors = new HashSet<Flavor>();
        }
    }
}
