using IServices.DTOs.Request.Category;
using IServices.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService theCategoryService)
        {
            _categoryService = theCategoryService;
        }
        [HttpPost]
        public IActionResult addCategory([FromBody]AddCategoryRequest req)
        {
            var result = _categoryService.addCategory(req);
            return Ok(result);
        }

    }
}
