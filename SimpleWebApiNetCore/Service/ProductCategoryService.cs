using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleWebApiNetCore.Entity;
using SimpleWebApiNetCore.EntityRepository;

namespace SimpleWebApiNetCore.Service
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IProductCategoryRepository _productCategoryRepository;

        public ProductCategoryService(IProductCategoryRepository productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }

        public Task<List<ProductCategory>> GetAll()
        {
            return _productCategoryRepository.FindAll().ToListAsync();
        }

        

        public void Delete(int id)
        {
            _productCategoryRepository.Remove(id);
        }

        public ProductCategory GetById(int id)
        {
            return _productCategoryRepository.FindById(id);
        }

        public void Add(ProductCategory productCategory)
        {
            _productCategoryRepository.Add(productCategory);
        }

        public void Update(ProductCategory productCategory)
        {
            _productCategoryRepository.Update(productCategory);
        }
    }
}
