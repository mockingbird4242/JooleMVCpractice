using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JooleDAL.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        //IRepository<T> Repository<T>() where T : class;
        IProduct Products { get; }
        IProject Projects { get; }
        int Commit();
    }
}
