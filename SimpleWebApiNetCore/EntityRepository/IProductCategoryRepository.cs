using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleWebApiNetCore.Entity;
using SimpleWebApiNetCore.Interface;

namespace SimpleWebApiNetCore.EntityRepository
{
    public interface IProductCategoryRepository :IRepository<ProductCategory, int>
    {
    }
}
