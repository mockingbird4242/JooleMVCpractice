using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JooleBLL.Repositories
{
    class Repository<T> : IRepository<T> where T : class
    {


        public void Delete(T entity)
        {
            //do some logic
        }

                public T GetById()
        {
            //do some logic
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetByName()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            //throw new NotImplementedException();
        }
    }
}
