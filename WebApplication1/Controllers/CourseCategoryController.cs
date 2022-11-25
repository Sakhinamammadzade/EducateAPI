using Business.Abstract;
using Core.Helpers.Results;
using Core.Helpers.Results.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoryController : ControllerBase
    {
        private readonly ICourseCategoryManager _courseCategoryManager;

        public CourseCategoryController(ICourseCategoryManager courseCategoryManager)
        {
            _courseCategoryManager = courseCategoryManager;
        }

        [HttpPost("addCourseCategory")]
        public IActionResult Add(CourseCategory courseCategory)
        {
            var result = _courseCategoryManager.Add(courseCategory);
              if(result.Success)
                return Ok(new {status=200,message=result.Success});
            return BadRequest(new { message = result.Message });

        }

        [HttpGet("getallCategory")]
        public IActionResult GetAll()
        {
            var result = _courseCategoryManager.GetcourseCategory();
            if(result.Success)
                return Ok(new { status = 200, data = result.Data });
            return BadRequest(new { data = result.Message });
        }

        [HttpGet("get/{id}")]

        public IActionResult GetById(string id)
        {
            var result = _courseCategoryManager.GetById(id);
            try
            {
                return Ok(new { data=result.Success });
            }
            catch (Exception)
            {
                return BadRequest(new { message = result.Message });
            }
          
               
         }
    }
}
