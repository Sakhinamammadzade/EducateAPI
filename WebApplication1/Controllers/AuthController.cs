using Business.Abstract;
using Business.Concrete;
using Business.Constance;
using Entities.DTOS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthManager _authManager;

        public AuthController(IAuthManager authManager)
        {
            _authManager = authManager;
        }


        [HttpPost("register")]
        public IActionResult Register(RegisterDTO register)
        {
            var result = _authManager.Register(register);
            if (result.Success)
            {
                return Ok(new { status = 200, message = Message.UserRegistered });
                //return Ok(result.Data);
            }
               return BadRequest(new {status=400,message=Message.ErrorOnRegsiter});
        }
        [HttpPost("login")]
        public IActionResult Login(LoginDTO loginDto)
        {
            var result=_authManager.Login(loginDto);
            if (result.Success)
            {
                return Ok(new {status=200, token=result.Message});

            }
            return BadRequest(new {status=401, message=result.Message});
        }

      
    }
}
