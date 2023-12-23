using Microsoft.AspNetCore.Mvc;
using TechCarrerTask2.Models;

namespace TechCarrerTask2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private List<Product> products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Chocolate",
                Unit = "Piece",
                Price = 10.5,
                Category = new Category { Id = 1, Name = "Snacks" }
            },
            new Product
            {
                Id = 2,
                Name = "Rice",
                Unit = "kg",
                Price = 15.0,
                Category = new Category { Id = 2, Name = "Grains" }

            },
            new Product
            {
                Id = 3,
                Name = "Milk",
                Unit = "Litre",
                Price = 20.0,
                Category = new Category { Id = 3, Name = "Dairy" }
            },
            new Product
            {
                Id = 4,
                Name = "Bread",
                Unit = "Piece",
                Price = 5.0,
                Category = new Category { Id = 4, Name = "Bakery" }
            },
            new Product
            {
                Id = 5,
                Name = "Butter",
                Unit = "Piece",
                Price = 10.0,
                Category = new Category { Id = 3, Name = "Dairy" }
            },
            
          
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Post(Product product)
        {
            product.Id = products.Count + 1;
            products.Add(product);

            return StatusCode(StatusCodes.Status201Created, product);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            products.Remove(product);
            return Ok(product);
        }
    }
}
