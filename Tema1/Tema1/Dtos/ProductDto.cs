using Tema1.Entities;

namespace Tema1.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public List<Product> Products { get; set; }
    }
}
