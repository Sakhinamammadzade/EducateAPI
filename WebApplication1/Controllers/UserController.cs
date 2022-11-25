using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using System.IdentityModel.Tokens.Jwt;

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

       [HttpGet("userList")]
       public IActionResult GetAllUser()
        {
            var users=_userManager.GetAllUsers();
            if (users.Success)
            {
                return Ok(new {status=200, message = users.Data});
            }

            return BadRequest();
        }
        [Authorize]
        [HttpGet("getbyemail")]
        public async Task<IActionResult> GetUserById()
        {
            var _bearer_token = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(_bearer_token);
            var email = jwtSecurityToken.Claims.FirstOrDefault(x => x.Type == "email").Value;

            var result = _userManager.GetUsersById(email);

            if (result.Success)
            {
                return Ok(new { status = 200, message = result .Data});
            }
            return BadRequest(new { status = 401, message = result.Message });
          
        }
    }
}
