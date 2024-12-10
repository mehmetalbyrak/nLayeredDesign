using nLayeredDesign.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nLayeredDesign.Business.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Object> TGetProductsWithCategory();
    }
}
