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
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDAL _customerDAL;

        public CustomerManager(ICustomerDAL customerDAL)
        {
            _customerDAL = customerDAL;
        }

        public void TDelete(Customer entity)
        {
            _customerDAL.Delete(entity);
        }

        public List<Customer> TGetAll()
        {
            return _customerDAL.GetAll();

        }

        public Customer TGetById(int id)
        {
            return _customerDAL.GetById(id);
        }

        public void TInsert(Customer entity)
        {
            if (entity.CustomerName != "" && entity.CustomerName.Length >= 3 && entity.CustomerCity != null && entity.CustomerLastName != "" && entity.CustomerName.Length <= 30)
            {
                    // adding process
                    _customerDAL.Insert(entity);
            }
            else
            {
                // error
            }
        }

        public void TUpdate(Customer entity)
        {
            _customerDAL.Update(entity);
        }
    }
}
