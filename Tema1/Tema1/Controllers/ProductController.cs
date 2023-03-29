using Tema1.Dtos;
using Tema1.Services;
using Tema1.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Tema1.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private ProductService ProductService { get; set; }


        public ProductsController(ProductService ProductService)
        {
            this.ProductService = ProductService;
        }

        [HttpGet("/get-all")]
        public ActionResult<List<Product>> GetAll()
        {
            var results = ProductService.GetAll();

            return Ok(results);
        }

        [HttpGet("/get/{productId}")]
        public ActionResult<Product> GetById(int productId)
        {
            var result = ProductService.GetById(productId);

            if (result == null)
            {
                return BadRequest("Product not fount");
            }

            return Ok(result);
        }

        [HttpPatch("edit-name")]
        public ActionResult<bool> GetById([FromBody] ProductDto productUpdateModel)
        {
            var result = ProductService.EditName(productUpdateModel);

            if (!result)
            {
                return BadRequest("Product could not be updated.");
            }

            return result;
        }

        [HttpDelete("delete/{productId}")]
        public ActionResult<ProductDto> DeleteProduct(int productId)
        {
            try
            {
                var productToDelete = ProductService.GetById(productId);

                if (productToDelete == null)
                {
                    return NotFound($"Product not found");
                }

                return ProductService.DeleteProduct(productId);
            }
            catch (Exception)
            {
                return BadRequest("Product could not be deleted.");
            }

        }
    }
}