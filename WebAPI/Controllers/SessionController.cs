using IServices.DTOs.Request.Session;
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
    public class SessionController : ControllerBase
    {
        private readonly ISessionService _sessionService;
        public SessionController(ISessionService theSessionService)
        {
            _sessionService = theSessionService;
        }

        [HttpPost]
        public IActionResult login([FromBody]LoginRequest req)
        {
            var result =_sessionService.login(req);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult register([FromBody]RegisterRequest req)
        {
            var result = _sessionService.register(req);
            return Ok(result);
        }
    }
}
