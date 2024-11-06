using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nLayeredDesign.Entity.Concrete
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string  CustomerLastName { get; set; }
        public string CustomerDistrict { get; set; }
        public string CustomerCity { get; set; }

        public ICollection<Order> Orders { get; set; }
    }

    // solid --> medium article for Single Responsibility
}
