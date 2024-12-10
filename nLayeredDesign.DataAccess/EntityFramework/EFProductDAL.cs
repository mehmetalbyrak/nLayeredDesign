using nLayeredDesign.DataAccess.Abstract;
using nLayeredDesign.DataAccess.Context;
using nLayeredDesign.DataAccess.Repositories;
using nLayeredDesign.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nLayeredDesign.DataAccess.EntityFramework
{
    public class EFProductDAL : GenericRepository<Product>, IProductDAL
    {
        public List<Object> GetProductsWithCategory()
        {
            var context = new CampContext();
            var values = context.Products
                .Select(x => new
                {
                    ProductId = x.ProductId,
                    ProductName = x.ProductName,
                    ProductStock = x.ProductStock,
                    ProductPrice = x.ProductPrice,
                    ProductDescription = x.ProductDescription,
                    CategoryName = x.Category.CategoryName
                }).ToList();

            return values.Cast<object>().ToList();
        }
    }
}
