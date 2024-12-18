﻿using nLayeredDesign.Business.Abstract;
using nLayeredDesign.DataAccess.Abstract;
using nLayeredDesign.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nLayeredDesign.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public void TDelete(Product entity)
        {
            _productDAL.Delete(entity);
        }

        public List<Product> TGetAll()
        {
            return _productDAL.GetAll();
        }

        public Product TGetById(int id)
        {
            return _productDAL.GetById(id);
        }

        public List<Object> TGetProductsWithCategory()
        {
            return _productDAL.GetProductsWithCategory();
        }

        public void TInsert(Product entity)
        {
            _productDAL.Insert(entity);
        }

        public void TUpdate(Product entity)
        {
            _productDAL.Update(entity);
        }
    }
}
