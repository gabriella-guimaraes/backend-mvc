using BackEndMVCDDD.Domain.Entities;
using BackEndMVCDDD.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BackEndMVCDDD.Infra.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public IEnumerable<Product> SearchByName(string name)
        {
            //Busca especializada
            return Db.Products.Where(p => p.Name == name);
        }
    }
}
