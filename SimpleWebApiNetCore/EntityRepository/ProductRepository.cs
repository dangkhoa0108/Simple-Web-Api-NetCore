using SimpleWebApiNetCore.Entity;
using SimpleWebApiNetCore.Implementation;

namespace SimpleWebApiNetCore.EntityRepository
{
    public class ProductRepository:EFRepository<Product, string>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}
