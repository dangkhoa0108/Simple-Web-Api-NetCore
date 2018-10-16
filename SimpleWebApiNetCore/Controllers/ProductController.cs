using Microsoft.AspNetCore.Mvc;
using SimpleWebApiNetCore.Service;

namespace SimpleWebApiNetCore.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetListProduct()
        {
            return new OkObjectResult(_productService.GetAll().Result);
        }

        [HttpPost("{id}")]
        public IActionResult Delete(string id)
        {
            _productService.Delete(id);
            return new OkObjectResult(_productService.GetAll().Result);
        }
    }
}