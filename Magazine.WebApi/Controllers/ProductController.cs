using Microsoft.AspNetCore.Mvc;
using Magazine.Core.Models;
using Magazine.Core.Services;
namespace Magazine.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public ActionResult<Product> Add(Product product)
        {
            try
            {
                var createdProduct = _productService.Add(product);
                return CreatedAtAction(nameof(Search), new { id = createdProduct.Id }, createdProduct);
            }
            catch (Exception ex)
            {
                // Обработка исключения
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Product> Remove(int id)
        {
            try
            {
                var deletedProduct = _productService.Remove(id);
                if (deletedProduct == null)
                {
                    return NotFound();
                }
                return deletedProduct;
            }
            catch (Exception ex)
            {
                // Обработка исключения
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        public ActionResult<Product> Edit(Product product)
        {
            try
            {
                var updatedProduct = _productService.Edit(product);
                if (updatedProduct == null)
                {
                    return NotFound();
                }
                return updatedProduct;
            }
            catch (Exception ex)
            {
                // Обработка исключения
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Product> Search(int id)
        {
            try
            {
                var product = _productService.Search(id);
                if (product == null)
                {
                    return NotFound();
                }
                return product;
            }
            catch (Exception ex)
            {
                // Обработка исключения
                return StatusCode(500, ex.Message);
            }
        }
    }
}
