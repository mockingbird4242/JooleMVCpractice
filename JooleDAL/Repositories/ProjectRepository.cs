using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JooleDAL.Entity;
using JooleDAL.Repositories;

namespace JooleDAL.Repositories
{
    class ProjectRepository : Repository<tblProject>, IProject
    {

        public ProjectRepository(JooleEntities entity)
            :base(entity)
        {
        }

        public JooleEntities JooleEntities
        {
            get { return _je as JooleEntities; }
            //in this class, always use JooleEntities to call LINQ method
        }

        public void DeleteByID(int number)
        {
            //JooleEntities.tblProjects.Remove();
            throw new NotImplementedException();
        }

        public IEnumerable<tblProject> GetByID()
        {
            throw new NotImplementedException();
        }
    }
}
