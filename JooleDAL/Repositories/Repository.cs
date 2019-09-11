using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using JooleDAL.Entity;
using JooleDAL.Repositories;
using System.Data.Entity;

namespace JooleDAL.Repositories
{
    class Repository<TEnity> : IRepository<TEnity> where TEnity : class
    {
        protected JooleEntities _je;
        //***private DbSet<TEnity> _dbset;
        //private JooleEntities<TEnity> dbSet = new JooleEntities<TEnity>();
        
        public Repository(JooleEntities entity)
        {
            this._je = entity;
            //***_dbset = entity.Set<TEnity>();         
        }    

        public IEnumerable<TEnity> GetAll()
        {
            return _je.Set<TEnity>().ToList();
        }

        public TEnity Get(int id)
        {
            return _je.Set<TEnity>().Find(id);
            //Or do this, they are same
            //return _dbset.Find(id);
        }

        public void Add(TEnity entity)
        {
            _je.Set<TEnity>().Add(entity);           
        }

        public void Remove(TEnity entity)
        {
            _je.Set<TEnity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEnity> entities)
        {
            _je.Set<TEnity>().RemoveRange(entities);
        }
    }
}
