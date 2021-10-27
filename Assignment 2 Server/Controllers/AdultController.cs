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
        private readonly IAdultRepository _adultRepository;
        public AdultController(IAdultRepository adultRepository)
        {
            _adultRepository = adultRepository;
        }

        [HttpGet]
        public ActionResult GetAdults()
        {
            try
            {
                return Ok(_adultRepository.GetAdults());
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

                adult.Id = _adultRepository.GetAdults().Count;
                await _adultRepository.AddAdult(adult);
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