using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JooleDAL.Entity;
using JooleDAL.Repositories;

namespace JooleDAL.Repositories
{
    public interface IProduct: IRepository<tblProduct>
    {
        IEnumerable<tblProduct> GetAllProducts();  //tblProduct is entity class
        IEnumerable<tblProduct> GetProductByID(int id);
        
        //add some other BASIC method
    }
}
