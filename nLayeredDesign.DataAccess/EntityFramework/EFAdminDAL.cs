using nLayeredDesign.DataAccess.Abstract;
using nLayeredDesign.DataAccess.Repositories;
using nLayeredDesign.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nLayeredDesign.DataAccess.EntityFramework
{
    public class EFAdminDAL : GenericRepository<Admin>, IAdminDAL
    {

    }
}
