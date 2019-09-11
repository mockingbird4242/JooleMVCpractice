using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JooleDAL.Entity;

namespace JooleDAL.Repositories
{
    public interface IProject : IRepository<tblProject>
    {
        //any specfic basic method in side
        IEnumerable<tblProject> GetByID();
        void DeleteByID(int number);
    }
}
