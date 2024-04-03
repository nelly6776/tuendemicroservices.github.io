using Microsoft.AspNetCore.Mvc;
using User.Models; // Import the namespace for the models
using System.Collections.Generic; // Import System.Collections.Generic for IEnumerable<T>

namespace User.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RiderController : ControllerBase
    {
        // GET: api/<RiderController>
        [HttpGet]
        public IEnumerable<Rider> Get()
        {
            // Return a list of riders
            return new List<Rider>
            {
                new Rider { Id = 1, Name = "Mboya" },
                new Rider { Id = 2, Name = "Lari" }
            };
        }

        // GET api/<RiderController>/5
        [HttpGet("{id}")]
        public ActionResult<Rider> Get(int id)
        {
            // Find and return the rider with the specified id
            var rider = new Rider { Id = id, Name = "Rider " + id };
            return Ok(rider);
        }

        // POST api/<RiderController>
        [HttpPost]
        public IActionResult Post([FromBody] Rider rider)
        {
            // Handle the creation of the rider
            // You can access rider properties like rider.Name, etc.
            return Ok();
        }

        // PUT api/<RiderController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Rider rider)
        {
        
           
            return Ok();
        }

        // DELETE api/<RiderController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            
            return Ok();
        }
    }
}
