using IServices.DTOs.Request.Post;
using IServices.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
        public PostController(IPostService thePostService)
        {
            _postService = thePostService;
        }
        [HttpGet]
        public IActionResult getPostsBetweenDates(DateTime d1, DateTime d2)
        {
            var result = _postService.getPostsBetweenDates(d1, d2);
            return Ok(result);
        }
        [HttpGet]
        public IActionResult getPostsByCategoryId(int categoryId)
        {
            var result = _postService.getPostsByCategoryId(categoryId);
            return Ok(result);
        }
        [HttpGet]
        public IActionResult getPostsByYear(int year)
        {
            var result = _postService.getPostsByYear(year);
            return Ok(result);
        }
    }
}
