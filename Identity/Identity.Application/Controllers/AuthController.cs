using Identity.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Identity.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpGet]
        public ActionResult<String> Get()
        {
            return "Health Check OK!!!";
        }

        [HttpPost("Authenticate")]
        [ProducesResponseType(statusCode: 200, Type = typeof(Token))]
        public ActionResult<Token> SignIn([FromBody] User user)
        {
            if (user.Email == "cauenogueira@alunos.utfpr.edu.br" && user.Password == "8c9df435feae1ae62cc4ed4c25f305a05dc4c25688b762660736091e8f6f5c00ab0d086a6a5e8a8c93d516230bb0b98f379658e26c57a64ffd2199df75e302af")
            {
                return Ok(new Token());
            }
            return Unauthorized();
        }
    }
}
