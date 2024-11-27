using nLayeredDesign.DataAccess.Abstract;
using nLayeredDesign.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nLayeredDesign.DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        CampContext context = new CampContext();
        DbSet<T> _myDbSet;

        public GenericRepository()
        {
            _myDbSet = context.Set<T>();
        }
        public void Delete(T Entity)
        {
            var deletedEntity = context.Entry(Entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _myDbSet.ToList();
        }

        public T GetById(int id)
        {
            return _myDbSet.Find(id);
        }

        public void Insert(T entity)
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
