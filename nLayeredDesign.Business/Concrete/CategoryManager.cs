using nLayeredDesign.Business.Abstract;
using nLayeredDesign.DataAccess.Abstract;
using nLayeredDesign.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nLayeredDesign.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        // dependency injection
        private readonly ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void TDelete(Category entity)
        {
            _categoryDAL.Delete(entity);
        }

        public List<Category> TGetAll()
        {
            return _categoryDAL.GetAll();
        }

        public Category TGetById(int id)
        {
            return _categoryDAL.GetById(id);
        }

        public void TInsert(Category entity)
        {
           _categoryDAL.Insert(entity);
        }

        public void TUpdate(Category entity)
        {
            _categoryDAL.Update(entity);
        }

        //  we invoked data access methods to the business layer
    }
}
