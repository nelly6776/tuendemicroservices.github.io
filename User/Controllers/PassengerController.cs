using Microsoft.AspNetCore.Mvc;
using User.Models; // Import the namespace for the models

namespace User.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        // GET: api/<PassengerController>
        [HttpGet]
        public IEnumerable<Passenger> Get()
        {
            // Return a list of passengers
            return new List<Passenger>
            {
                new Passenger { Id = 1, Name = "Passenger 1", Email = "passenger1@example.com" },
                new Passenger { Id = 2, Name = "Passenger 2", Email = "passenger2@example.com" }
            };
        }

        // GET api/<PassengerController>/5
        [HttpGet("{id}")]
        public ActionResult<Passenger> Get(int id)
        {
            // Find and return the passenger with the specified id
            var passenger = new Passenger { Id = id, Name = "Passenger " + id, Email = "passenger" + id + "@example.com" };
            return Ok(passenger);
        }

        // POST api/<PassengerController>
        [HttpPost]
        public IActionResult Post([FromBody] Passenger passenger)
        {
            // Handle the creation of the passenger
            // You can access passenger properties like passenger.Name, passenger.Email, etc.
            // For simplicity, let's just return Ok for now
            return Ok();
        }

        // PUT api/<PassengerController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Passenger passenger)
        {
            // Handle the update of the passenger with the specified id
            // You can access updated passenger properties like passenger.Name, passenger.Email, etc.
            // For simplicity, let's just return Ok for now
            return Ok();
        }

        // DELETE api/<PassengerController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Handle the deletion of the passenger with the specified id
            // For simplicity, let's just return Ok for now
            return Ok();
        }
    }
}
