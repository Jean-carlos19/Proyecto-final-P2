using Microsoft.AspNetCore.Mvc;

namespace MiPrimerAPI.Controllers
{
    public class ProductController : ControllerBase
    {
        private readonly ProductService _service;
        public ProductController(ProductService service) => _service =
        service;
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _service.GetAllProducts();
            return Ok(products);
        }
    }
}
