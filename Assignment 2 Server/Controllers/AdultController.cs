using System;
using System.Threading.Tasks;
using Assignment_2_Server.Data.Models;
using Assignment_2_Server.Data.Persistence;
using Microsoft.AspNetCore.Mvc;


namespace Assignment_2_Server.Controllers
{
    [Route("[controller]s")]
    [ApiController]
    public class AdultController : ControllerBase
    {
        private readonly IAdultRepository AdultRepository;
        public AdultController()
        {
            AdultRepository = new AdultRepository();
        }

        [HttpGet]
        public async Task<ActionResult> GetAdults()
        {
            try
            {
                return Ok(AdultRepository.GetAdults());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        [HttpPost]
        public async Task<ActionResult<Adult>> CreateAdult(Adult adult)
        {
            try
            {
                if (adult == null)
                {
                    return BadRequest();
                }

                AdultRepository.AddAdult(adult);
                return CreatedAtAction(nameof(GetAdults), new {adult.Id});
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}