using Tema1.Dtos;
using Tema1.Entities;
using Tema1.Mappings;
using Tema1.Repositories;

namespace Tema1.Services
{
    public class ProductService
    {
        private ProductRepository productRepository { get; set; }

        public ProductService(ProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public List<Product> GetAll()
        {
            var results = productRepository.GetAll();

            return results;
        }

        public Product GetById(int productId)
        {
            var result = productRepository.GetById(productId);

            return result;
        }

        public bool EditName(ProductDto payload)
        {
            if (payload == null || payload.Name == null)
            {
                return false;
            }

            var result = productRepository.GetById(payload.Id);
            if (result == null) return false;

            result.Name = payload.Name;

            return true;
        }

        public ProductDto DeleteProduct(int productId)
        {
            var result = productRepository.DeleteProduct(productId);
            return result.ToProductDto();
        }
    }
}