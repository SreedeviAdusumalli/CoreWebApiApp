using CoreWebApiApp.DTOs;
using CoreWebApiApp.Models;
using CoreWebApiApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Swagger;

namespace CoreWebApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        /*
        private List<Category> _categories = new List<Category>
        {
            new Category {Id = 1, Name = "Electronics"},
            new Category {Id = 2, Name = "Furniture"}
        };
        private static List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1000.00m, CategoryId = 1 },
            new Product { Id = 2, Name = "Desktop", Price = 2000.00m, CategoryId = 1 },
            new Product { Id = 3, Name = "Chair", Price = 150.00m, CategoryId = 2 }
        };

        // GET: api/Product
        [HttpGet]
        public ActionResult<IEnumerable<ProductDTO>> GetProducts()
        {
            var productDTOs = _products.Select(p => new ProductDTO
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                CategoryName = _categories.FirstOrDefault(c => c.Id == p.CategoryId)?.Name ?? "Unknown"
            }).ToList();

            return Ok(productDTOs);
        }

        //GET: api/Product/{id}    Get product by Id
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound(new { Message = $"Product with ID {id} is not found!" });
            }

            var productDTO = new ProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                CategoryName = _categories.FirstOrDefault(c => c.Id == product.CategoryId)?.Name ?? "Unknown"
            };

            return Ok(productDTO);
        }

        //POST: api/products
        [HttpPost]
        public ActionResult<ProductDTO> PostProduct([FromBody] ProductCreateDTO createDTO)
        {
            var newProduct = new Product { 
                Id = _products.Max(p => p.Id) + 1, 
                Name = createDTO.Name,
                Price = createDTO.Price,
                CategoryId = createDTO.CategoryId
            };

            _products.Add(newProduct);

            var productDTO = new ProductDTO { Id = newProduct.Id,
                Name = newProduct.Name,
                CategoryName = _categories.FirstOrDefault(p => p.Id == newProduct.Id)?.Name ?? "Unknown",
                Price = newProduct.Price };

            return CreatedAtAction(nameof(GetProduct), new { Id = productDTO.Id }, productDTO);

        }

        //PUT: api/products/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] ProductUpdateDTO updateDTO)
        {
            if (id != updateDTO.Id)
                return BadRequest(new { Message = "Id mismatch between route and body." });

            var existingProduct = _products.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null)
                return NotFound(new { Message = $"product with Id {id} is not found." });

            existingProduct.Name = updateDTO.Name;
            existingProduct.Price = updateDTO.Price;
            existingProduct.CategoryId = updateDTO.CategoryId;

            return NoContent();
        }

        //DELETE: api/products/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return NotFound(new { Message = $"Product with Id {id} not found" });

            _products.Remove(product);

            return NoContent();
        }
    }
        */

        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductDTO>> GetProducts()
        {
            return Ok(_productService.GetAllProducts());
        }

        [HttpGet("{id}")]
        public ActionResult<ProductDTO> GetProduct(int id)
        {
            var product = _productService.GetProductById(id);
            if (product == null) { return NotFound(new { Message = $"Product with Id {id} is not found!" }); }
            ;

            return Ok(product);
        }

        [HttpPost]
        public ActionResult<ProductDTO> PostProduct(ProductCreateDTO productDTO)
        {
            ProductDTO newProduct = _productService.CreateProduct(productDTO);

            return CreatedAtAction(nameof(GetProduct), new { id = newProduct.Id }, newProduct);

        }

        [HttpPut]
        public IActionResult UpdateProduct(int id, [FromBody] ProductUpdateDTO updateDTO)
        {
            if (id != updateDTO.Id) return BadRequest(new { Message = "ID mismatch between the route and request body!" });
            if (!_productService.UpdateProduct(id, updateDTO)) return NotFound(new { Message = $"Product with Id {id} is not found!" });

            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            if (!_productService.DeleteProduct(id)) return NotFound(new { Message = $"Product with Id {id} is not found!" });

            return NoContent();
        }
    }
}

