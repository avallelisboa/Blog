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
        [HttpPost]
        public IActionResult addPost(AddPostRequest req)
        {
            var result = _postService.makePost(req);
            return Ok(result);
        }
    }
}
