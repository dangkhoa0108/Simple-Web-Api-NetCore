using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleWebApiNetCore.Entity;

namespace SimpleWebApiNetCore.Service
{
    public interface IProductService
    {
        Task<List<Product>> GetAll();
        void Delete(string id);
    }
}
