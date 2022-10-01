using Business.Abstract;
using Business.Constance;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouseController : ControllerBase
    {
        private readonly ICourseServices _couserService;

        public CouseController(ICourseServices couserService)
        {
            _couserService = couserService;
        }

        [HttpPost("addcourse")]
        public IActionResult Add(Course course)
        {
            var result=_couserService.Add(course);
            if (result.Success)
                return Ok(new { status = 200, message = result.Message });
            return BadRequest(new {message=result.Message});
            }

        }

    } 

