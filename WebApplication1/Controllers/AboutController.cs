using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutManager _aboutManager;

        public AboutController(IAboutManager aboutManager)
        {
            _aboutManager = aboutManager;
        }

        [HttpGet("get/{id}")]
        public IActionResult Get(string id)
        {
            var result = _aboutManager.GetById(id);
            if (result.Success)
            {
                return Ok(new { data = result.Data });
            }
            else
            {
                return BadRequest(new { message = result.Message });
            }

        }
        [HttpGet("Aboutget")]
        public IActionResult GetAll()
        {
            var result = _aboutManager.GetAll();
            if (result.Success)
                return Ok(new { data = result.Data });
            return BadRequest(new { message = result.Message });
        }

        [HttpPost("aboutAdd")]
        public IActionResult Add(About about)
        {
            var result = _aboutManager.Add(about);
            if (result.Success)
                return Ok(new { status = 200, message = result.Message });
            return BadRequest(new { message = result.Message });
        }
    }
}
