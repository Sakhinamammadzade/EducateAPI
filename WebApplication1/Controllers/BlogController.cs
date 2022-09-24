using Business.Abstract;
using Business.Constance;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogManager _blogManager;

        public BlogController(IBlogManager blogManager)
        {
            _blogManager = blogManager;
        }

        [HttpPost("addblog")]
        public IActionResult AddBlog(Blog blog)
        {
            var addblog = _blogManager.Add(blog);
            if (addblog.Success)
                return Ok(new { status = 200, message = "elave olundu" });
            return BadRequest(new { status = 400 , message = "not found"});
        }

        [HttpGet("getblog")]
        public IActionResult GetBlog(int id)
        {
            var getblog = _blogManager.GetById(id);
            if (getblog.Success)
                return Ok(new { status = 200, message = "blog tapildi" });
            return BadRequest(new { status = 400, message = "error" });

        }
        [HttpPost("allblog")]
        public IActionResult GetAllBlog()
        {
            var blog = _blogManager.GetAll();
            if(blog.Success) 
                return Ok(new { status = 200, message = "blog tapildi" });
            return BadRequest(new { status = 400, message = "error" });

        }
        [HttpPost("deleteblog")]
        public IActionResult DeleteBlog(int id)
        {
            var blog = _blogManager.Remove(id);
            if (blog.Success)
                return Ok(new { status = 200, message = "blog silindi" });
            return BadRequest(new { status = 400, message = "silinme zamani xeta bas verdi" });

        }
        [HttpPost("updateblog")]
        public IActionResult UpdateBlog(Blog blog)
        {
            var updateblog = _blogManager.Update(blog);
            if (updateblog.Success)
                return Ok(new { status = 200, message = "blog silindi" });
            return BadRequest(new { status = 400, message = "silinme zamani xeta bas verdi" });

        }










    }
}
