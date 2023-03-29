using Tema1.Entities;

namespace Tema1.Repositories
{
    public class ProductRepository
    {
        public List<Product> GetAll()
        {
            var results = DbContext.Products;

            return results;
        }

        public Product GetById(int productId)
        {
            var result = DbContext.Products
                .Where(e => e.Id == productId)
                .FirstOrDefault();

            return result;
        }

        public Product DeleteProduct(int productId)
        {
            var result = DbContext.Products
           .FirstOrDefault(e => e.Id == productId);
            if (result != null)
            {
                DbContext.Products.Remove(result);
                return result;
            }

            return null;
        }
    }
}