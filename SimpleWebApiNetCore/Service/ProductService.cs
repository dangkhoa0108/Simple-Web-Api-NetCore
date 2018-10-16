using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleWebApiNetCore.Entity;
using SimpleWebApiNetCore.EntityRepository;

namespace SimpleWebApiNetCore.Service
{
    public class ProductService:IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<List<Product>> GetAll()
        {
            return _productRepository.FindAll().ToListAsync();
        }

        public  void Delete(string id)
        {
            _productRepository.Remove(id);
        }
    }
}
