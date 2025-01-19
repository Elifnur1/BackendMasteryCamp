using EShop.Services.Abstract;
using EShop.Services.Concrete;
using EShop.Shared.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShop.API.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryManager;

        public CategoriesController(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [Authorize("Admin")]
        [HttpPut]
        public async Task<IActionResult> Update(CategoryUpdateDto categoryUpdateDto)
        {
            var response = await _categoryManager.UpdateAsync(categoryUpdateDto);
            return StatusCode(response.StatusCode, response);
        }

        [Authorize("Admin")]
        [HttpGet("Harddelete/{id}")]
        public async Task<IActionResult> HardDelete(int id)
        {
            var response = await _categoryManager.HardDeleteAsync(id);
            return StatusCode(response.StatusCode, response);
        }
        [Authorize("Admin")]
        [HttpGet("Softdelete/{id}")]
        public async Task<IActionResult> SoftDelete(int id)
        {
            var response = await _categoryManager.SoftDeleteAsync(id);
            return StatusCode(response.StatusCode, response);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Add(CategoryCreateDto categoryCreateDto)
        {
            var response = await _categoryManager.AddAsync(categoryCreateDto);
            return StatusCode(response.StatusCode, response);
        }


        [Authorize(Roles = "Admin")]
        [HttpGet("all")]
        public async Task<IActionResult> GetAllCategories()
        {
            var response = await _categoryManager.GetAllAsync();
            return StatusCode(response.StatusCode, response);
        }


        [HttpGet("actives")]
        public async Task<IActionResult> GetActives()
        {
            var response = await _categoryManager.GetAllAsync(true);
            return StatusCode(response.StatusCode, response);
        }


        [Authorize(Roles = "Admin")]
        [HttpGet("passives")]
        public async Task<IActionResult> GetPassives()
        {
            var response = await _categoryManager.GetAllAsync(false);
            return StatusCode(response.StatusCode, response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _categoryManager.GetAsync(id);
            return StatusCode(response.StatusCode, response);
        }

        [Authorize("Admin")]
        [HttpGet("count/all")]
        public async Task<IActionResult> CountAll()
        {
            var response = await _categoryManager.CountAsync();
            return StatusCode(response.StatusCode, response);
        }
        [HttpGet("count/actives")]
        public async Task<IActionResult> CountActives()
        {
            var response = await _categoryManager.CountAsync(true);
            return StatusCode(response.StatusCode, response);
        }







    }
}
