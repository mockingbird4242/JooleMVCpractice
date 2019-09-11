using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JooleBLL.Repositories
{
    interface IRepository<T>: IDisposable
    {
        IEnumerable<T> GetByName();
        void Delete(T entity);
        T GetById();
    }
}
