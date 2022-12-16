using Code_Patterns_Api.Data;
using Code_Patterns_Api.Handlers;
using Code_Patterns_Api.Models;
using Code_Patterns_Api.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Code_Patterns_Api.Controllers

//  Den här Controlleren bidrar också i DRY, jag behöver inte upprepa
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryHandler _categoryHandler;
       
        public CategoryController(ICategoryHandler categoryHandler)
        {
            _categoryHandler = categoryHandler;
        }

        [HttpPost]
        public async Task<IActionResult> Greate(Category category)
        {
            await _categoryHandler.CreateAsync(category);
            return Created("", null);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var category = await _categoryHandler.GetAllAsync();
            return new OkObjectResult(category);
        }
    }
}
