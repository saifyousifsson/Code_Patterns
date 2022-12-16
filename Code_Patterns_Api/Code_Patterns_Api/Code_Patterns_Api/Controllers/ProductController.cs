using Code_Patterns_Api.Handlers;
using Code_Patterns_Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Code_Patterns_Api.Controllers
{
    //  Den här Controlleren bidrar också i DRY, jag behöver inte upprepa

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductHandler _productHandler;

        public ProductController(IProductHandler productHandler)
        {
            _productHandler = productHandler;
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductRequest req)
        {
            await _productHandler.CreateAsync(req);
            return Created("", null);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
           var products= await _productHandler.GetAllAsync();
            return new OkObjectResult(products);
        }

        //[HttpGet]
        //public List<Product> GetAllpProduct()

        //{
        //   //var group = _context.categories.Include("products").Where(x=>x.Name==x.Name).ToList();
        //    //return _context.products.Include("Category").Where(x=>x.Name==x.Name).ToList();
        //}

    }
}
