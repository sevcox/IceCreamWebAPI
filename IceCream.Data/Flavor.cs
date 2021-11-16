using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCream.Data
{
    public class Flavor
    {
        [Key]
        public int FlavorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Order> ListOfOrders { get; set; }

        public Flavor()
        {
            ListOfOrders = new HashSet<Order>();
        }
    }
}
