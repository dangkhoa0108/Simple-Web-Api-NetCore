using Microsoft.AspNetCore.Mvc;
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
    }
}