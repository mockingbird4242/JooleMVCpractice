using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JooleDAL.Entity;

namespace JooleDAL.Repositories
{
    class ProductRepository : Repository<tblProduct>, IProduct
    {
        //private JooleEntities _je;

        public ProductRepository(JooleEntities entity)
            :base(entity)
        {
            //this._je = entity;
        }

        public JooleEntities JooleEntities
        {
            get { return _je as JooleEntities; }
            //in this class, always use JooleEntities to call LINQ method
        }

        public IEnumerable<tblProduct> GetAllProducts()
        {
            var result = JooleEntities.tblProducts.OrderBy(x=>x.Model_Year).ToList();
            return result;
        }

        public IEnumerable<tblProduct> GetProductByID(int id)
        {
            //return JooleEntities.tblProducts.Select(x => x.Product_ID == id).ToList();
            throw new NotImplementedException();
        }
    }
}
