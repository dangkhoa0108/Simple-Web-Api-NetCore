using SimpleWebApiNetCore.Entity;
using SimpleWebApiNetCore.Interface;

namespace SimpleWebApiNetCore.EntityRepository
{
    public interface IProductRepository:IRepository<Product, string>
    {
    }
}
