using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleWebApiNetCore.Entity;
using SimpleWebApiNetCore.EntityRepository;

namespace SimpleWebApiNetCore.Service
{
    public interface IProductCategoryService
    {
        Task<List<ProductCategory>> GetAll();

        void Delete(int id);

        ProductCategory GetById(int id);

        void Add(ProductCategory productCategory);

        void Update(ProductCategory productCategory);
    }
}
