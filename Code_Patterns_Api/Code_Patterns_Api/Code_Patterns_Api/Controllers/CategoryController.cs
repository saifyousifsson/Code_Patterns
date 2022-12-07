using Code_Patterns_Api.Data;
using Code_Patterns_Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Code_Patterns_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly DataContext _context;
        public CategoryController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public List<Category> GetAllCategory()
        {
            return _context.categories.ToList();
        }
    }
}
