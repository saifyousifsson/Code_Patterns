using Code_Patterns_Api.Data;
using Code_Patterns_Api.Factories;
using Code_Patterns_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Code_Patterns_Api.Handlers
{
    /// CategoryHandler ärver sina fält från ICategoryHandler, på grund av LSP,
    public interface ICategoryHandler
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task CreateAsync(Category category);
    }
    public class CategoryHandler : ICategoryHandler
    {
        private readonly DataContext _context;
        private readonly ICategoryFactory _categoryFactory;

        public CategoryHandler(DataContext context, ICategoryFactory categoryFactory)
        {
            _context = context;
            _categoryFactory = categoryFactory;
        }
        public async Task CreateAsync(Category category)
        {
            var categoryEntity = _categoryFactory.categoryEntity();
            {
                categoryEntity.Name = category.Name;
                categoryEntity.Imag = category.Imag;
                _context.Add(categoryEntity);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            List<Category> categories = _categoryFactory.CategoryList();
            foreach (var categoryEntity in await _context.categories.ToListAsync())
                categories.Add(_categoryFactory.category(categoryEntity));
            return categories;
        }
    }
}
