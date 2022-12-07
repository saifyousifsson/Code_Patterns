using Code_Patterns_Api.Data;
using Code_Patterns_Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Code_Patterns_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrroductController : ControllerBase
    {
        private readonly DataContext _context;
        public PrroductController( DataContext context)
       
        {
         
            _context = context;
        }

        [HttpGet]
        public List<Product> GetAllpProduct()

        {
           //var group = _context.categories.Include("products").Where(x=>x.Name==x.Name).ToList();
            return _context.products.Include("Category").Where(x=>x.Name==x.Name).ToList();
        }

    }
}
