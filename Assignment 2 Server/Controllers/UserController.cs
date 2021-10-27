using System;
using Assignment_2_Server.Data.Models;
using Assignment_2_Server.Logic;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_2_Server.Controllers
{
    [Route("[controller]s")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IVerifier _verifier;

        public UserController(IVerifier verifier)
        {
            _verifier = verifier;
        }
        
        
        [HttpPost]
        public ActionResult UserLogin(User user)
        {
            try
            {
                if (user == null)
                {
                    return BadRequest();
                }

                return Ok(_verifier.Authorize(user.Username, user.Password));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
    }
}