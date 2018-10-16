using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleWebApiNetCore.Entity;
using SimpleWebApiNetCore.Implementation;

namespace SimpleWebApiNetCore.EntityRepository
{
    public class ProductCategoryRepository : EFRepository<ProductCategory, int>, IProductCategoryRepository
    {
        public ProductCategoryRepository(AppDbContext context) : base(context)
        {

        }
    }
}
