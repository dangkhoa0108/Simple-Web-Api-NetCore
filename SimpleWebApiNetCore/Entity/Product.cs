using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleWebApiNetCore.Entity
{
    [Table("Products")]
    public class Product:KeyEntity<string>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreate { get; set; }


        public int CategoryId { set; get; }

        [ForeignKey("CategoryId")]
        public virtual ProductCategory ProductCategory { set; get; }
    }
}
