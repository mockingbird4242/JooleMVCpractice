using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JooleDAL.Repositories;
using JooleDAL.Entity;

namespace JooleDAL.Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        private JooleEntities _je;
        
        public IProduct Products { get; private set; }
        public IProject Projects { get; private set; }

        //*************1.1 define***************
        //private ProductRepository _prodectRepo;
        //private ProjectRepository _projectRepo;
        //*************1.1***************
        public UnitOfWork(JooleEntities entity)
        {
            this._je = entity;
            Products = new ProductRepository(_je);
            Projects = new ProjectRepository(_je);
            //need modify the projectRepository, when we add any Repository, we just add here
        }
        //optional constructor, itself will create the Entity**********<top and bottom>
        public UnitOfWork()
        {
            this._je = new JooleEntities();
            Products = new ProductRepository(_je);
            Projects = new ProjectRepository(_je);
        }

        public int Commit()
        {
            return _je.SaveChanges();
        }

        public void Dispose()
        {
            _je.Dispose();            
        }

        

        //****************1.1 implementation**********************
        //public ProductRepository PorductRepo
        //{
        //    get
        //    {
        //        if(_prodectRepo == null)
        //        {
        //            _prodectRepo = new ProductRepository(_je);
        //        }
        //        return _prodectRepo;
        //    }
        //}

        //public ProjectRepository ProjectRepo
        //{
        //    get
        //    {
        //        if(_projectRepo == null){
        //            _projectRepo = new ProjectRepository(_je);
        //        }
        //        return _projectRepo;
        //    }
        //}
        //*****************************************

    }
}
