using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nLayeredDesign.Entity.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public int ProductPrice { get; set; }
        public string ProductDescription { get; set; }

        public int CatgeoryId { get; set; }
        public virtual Category Category { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
