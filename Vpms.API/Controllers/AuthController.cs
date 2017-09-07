using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vpms.Business;
using Vpms.Model;

namespace Vpms.API.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private IAuthService userService;

        public AuthController(IAuthService userService)
        {
            this.userService = userService;
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody]LoginRequest model){
            AuthResponse response = new AuthResponse();
            string tokenId=string.Empty;
            if (userService.Login(model,out tokenId) != 0)
            {
                response.Token = tokenId;
                response.IsAuthenticated = true;
                return Ok(response);
            }

            return Unauthorized();
        }


        [HttpPost("Register")]
        public IActionResult Register([FromBody]RegisterRequest model)
        {
            if (ModelState.IsValid)
            {
                AuthResponse response = new AuthResponse();
                // Create a new Username
                int status = userService.Register(model);
                if (status == 1)
                {
                    response.Token = "token";
                    response.IsAuthenticated = true;
                    return Ok(response);
                }
                return BadRequest();
            }
            
            return BadRequest();
        }
        // // GET api/values
        // [HttpGet]
        // public IEnumerable<string> Get()
        // {
        //     return new string[] { "value1", "value2" };
        // }

        // // GET api/values/5
        // [HttpGet("{id}")]
        // public string Get(int id)
        // {
        //     return "value";
        // }

        // // POST api/values
        // [HttpPost]
        // public void Post([FromBody]string value)
        // {
        // }

        // // PUT api/values/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody]string value)
        // {
        // }

        // // DELETE api/values/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }
    }
}
