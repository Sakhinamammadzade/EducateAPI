using Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserManager _userManager;

        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }
        [Authorize]
       [HttpGet("userList")]
       public IActionResult GetAllUser()
        {
            var users=_userManager.GetAllUsers();
            if (users.Success)
            {
                return Ok(new {status=200,message=users.Data});
            }

            return BadRequest();
        }
    }
}
