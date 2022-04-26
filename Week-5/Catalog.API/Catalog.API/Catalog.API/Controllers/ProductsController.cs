using Catalog.Business;
using Catalog.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {   [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = new ProductService().GetAll();
            return Ok(products);
        }
    }
}
