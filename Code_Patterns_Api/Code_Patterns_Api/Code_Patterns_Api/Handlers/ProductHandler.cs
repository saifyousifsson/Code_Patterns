using Code_Patterns_Api.Data;
using Code_Patterns_Api.Factory;
using Code_Patterns_Api.Models;
using Code_Patterns_Api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Code_Patterns_Api.Handlers
{

    public interface IProductHandler
    {
        Task CreateAsync(ProductRequest product);
        Task<IEnumerable<Product>> GetAllAsync();
        Task<ProductEntity> GettAsync(int id);
    }
    public class ProductHandler :IProductHandler
    {
        private readonly DataContext _context;
        private readonly IProductFactory _productFactory;

        public ProductHandler(DataContext context, IProductFactory productFactory)
        {
            _context = context;
            _productFactory = productFactory;
        }

        public async Task CreateAsync(ProductRequest product)
        {
            var productEntity = _productFactory.ProductEntity();
            productEntity.Name = product.Name;
            productEntity.Price = product.Price;
            productEntity.Imag = product.Imag;
            productEntity.CategoryId= product.CategoryId;
            _context.Add(productEntity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {   List<Product> products = _productFactory.ProductList();
            foreach (var productEntity in await _context.products.Include(x => x.Category).ToListAsync()) 
                products.Add(_productFactory.Product(productEntity));
            return products;
        }

        public Task<ProductEntity> GettAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
