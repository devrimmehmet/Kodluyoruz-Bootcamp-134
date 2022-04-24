using IntroAPI6.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IntroAPI6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        List<Product> products;
        public ProductsController()
        {
             products = new List<Product>
            {
                new Product {Id=1,Name="Product 1", Description="Product 1", Discount=0.1, ImageUrl="https://picsum.photos/200/300", Price=10,Stock=100},
                new Product {Id=2,Name="Product 2", Description="Product 2", Discount=0.1, ImageUrl="https://picsum.photos/200/300", Price=100,Stock=90},
                new Product {Id=3,Name="Product 3", Description="Product 3", Discount=0.1, ImageUrl="https://picsum.photos/200/300", Price=150,Stock=80},
                new Product {Id=4,Name="Product 4", Description="Product 4", Discount=0.1, ImageUrl="https://picsum.photos/200/300", Price=130,Stock=70}
            };
        }


        [HttpGet]
        public IActionResult GetProducts()
        {
           
            return Ok(products);
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            // Model Binder, Http request body'sinden gelen verileri product nesnesine dönüştürür.
            if (ModelState.IsValid)
            {
                return Created("http://www.myproduct.com/product/1",product);
               // return StatusCodes.Status201Created;
            }
            return BadRequest(ModelState);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct([FromRoute]int id)
        {
            var product= products.Find(p=>p.Id==id);
            if (product==null)
            {
                return NotFound(new {message=$"{id} numaralı ürün bulunamadı"});
            }
            return Ok(product);
        }
        //[HttpGet]
        //public IActionResult SearchProductByName(string name)
        //{
        //    return Ok();
        //}
    }
}
