using Code_Patterns_Api.Interfaces;
using Code_Patterns_Api.Models;
using Code_Patterns_Api.Models.Entities;

namespace Code_Patterns_Api.Factory
{
    public interface IProductFactory : IFactory
    {
        ProductEntity ProductEntity();
        List<Product> ProductList();
        Product Product(ProductEntity productEntity);
    }
        public class ProductFactory : IProductFactory
        {
            public ProductEntity ProductEntity()
            {
                return new ProductEntity();
            }
            public Product Product(ProductEntity productEntity)
            {
            return new Product()
            {
                Id = productEntity.Id,
                Name = productEntity.Name,
                Imag = productEntity.Imag,
                Price = productEntity.Price,
                CategoryId = productEntity.Category.Id,
                CategoryName = productEntity.Category.Name,

            };
            }

            public List<Product> ProductList()
            {
                return new List<Product>();
            }
        }
    
}
