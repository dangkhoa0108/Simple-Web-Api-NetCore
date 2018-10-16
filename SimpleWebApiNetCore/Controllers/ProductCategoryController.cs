using Microsoft.AspNetCore.Mvc;
using SimpleWebApiNetCore.Entity;
using SimpleWebApiNetCore.Service;

namespace SimpleWebApiNetCore.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ProductCategoryController : Controller
    {
        private readonly IProductCategoryService _productCategoryService;

        public ProductCategoryController(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return new OkObjectResult(_productCategoryService.GetAll().Result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productCategoryService.Delete(id);
            return new OkObjectResult(_productCategoryService.GetAll().Result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return new OkObjectResult(_productCategoryService.GetById(id));
        }

        //[HttpPost]
        //public IActionResult Add(ProductCategory productCategory)
        //{
        //    _productCategoryService.Add(productCategory);
        //    return new OkObjectResult(_productCategoryService.GetAll().Result);
        //}

        //[HttpPost]
        //public IActionResult Update(ProductCategory productCategory)
        //{
        //    var item = _productCategoryService.GetById(productCategory.Id);
        //    item.Description = productCategory.Description;
        //    item.Name = productCategory.Name;
        //    _productCategoryService.Update(item);
        //    return new OkObjectResult(_productCategoryService.GetAll().Result);
        //}

        [HttpPost]
        public IActionResult SaveAddOrUpdate(ProductCategory productCategory)
        {
            var id = productCategory.Id;
            if (!string.IsNullOrEmpty(id.ToString()))
            {
                if (id == 0)
                {
                    _productCategoryService.Add(productCategory);
                }
                var item = _productCategoryService.GetById(productCategory.Id);
                item.Description = productCategory.Description;
                item.Name = productCategory.Name;
                _productCategoryService.Update(item);
            }
            return new OkObjectResult(_productCategoryService.GetAll().Result);
        }
    }
}