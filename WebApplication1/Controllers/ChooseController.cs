using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChooseController : ControllerBase
    {
        private readonly IChooseManager _chooseManager;

        public ChooseController(IChooseManager chooseManager)
        {
            _chooseManager = chooseManager;
        }


        [HttpPost("addchoose")]
        public IActionResult Add(ChooseCourse choose)
        {
            var result =_chooseManager.Add(choose);
            if (result.Success)
                return Ok(new { status = 200, message = result.Message });
            return BadRequest(new { message = result.Message });
        }

    }



}

