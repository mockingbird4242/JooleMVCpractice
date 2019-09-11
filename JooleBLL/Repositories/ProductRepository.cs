using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JooleDAL.Entity;

namespace JooleBLL.Repositories
{
    class ProductRepository : IRepository<tblProduct>   //tblProduct is entity class from EF from DAL
    {
        public void Delete(tblProduct entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public tblProduct GetById()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tblProduct> GetByName()
        {
            throw new NotImplementedException();
        }
    }
}
