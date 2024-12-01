
using BackEndMVCDDD.Domain.Entities;
using System.Collections;
using System.Collections.Generic;

namespace BackEndMVCDDD.Domain.Interfaces
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IEnumerable<Product> SearchByName(string name);
    }
}
