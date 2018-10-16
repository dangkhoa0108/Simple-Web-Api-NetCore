using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApiNetCore.Entity
{
    [Table("ProductCategories")]
    public class ProductCategory : KeyEntity<int>
    {
        public string Name { set; get; }

        public string Description { set; get; }

        public virtual ICollection<Product> Products { set; get; }
    }
}
