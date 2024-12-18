using BackEndMVCDDD.Domain.Entities;
using BackEndMVCDDD.Domain.Interfaces.Repositories;
using BackEndMVCDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndMVCDDD.Domain.Services
{
    public class ProductService : ServiceBase<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
            : base(productRepository)
        {
            _productRepository = productRepository;
            
        }

        public IEnumerable<Product> SearchByName(string name)
        {
            return _productRepository.SearchByName(name);
        }
    }
}
