using Tema1.Dtos;
using Tema1.Entities;

namespace Tema1.Mappings
{
    public static class ProductMappings
    {
        public static List<ProductDto> ToProductDtos(this List<Product> Products)
        {
            var results = Products.Select(e => e.ToProductDto()).ToList();

            return results;
        }

        public static ProductDto ToProductDto(this Product Product)
        {
            if (Product == null) return null;

            var result = new ProductDto();
            result.Name = Product.Name ;
            result.Price = Product.Price;

            return result;
        }

    }
}
