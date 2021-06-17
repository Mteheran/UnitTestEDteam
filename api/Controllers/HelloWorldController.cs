using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        public HelloWorldController()
        {
        }

        [HttpGet("")]
        public ActionResult<IEnumerable<string>> GetTModels()
        {
            return new List<string> { "Hello World", "Hello World2" };
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetById(int id)
        {
            if(id < 0) return BadRequest();

            if(id ==0) return  NotFound();

            return "Hello World";
        }


        [HttpPost("")]
        public ActionResult PostTModel(string model)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult PutTModel(string model)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<string> DeleteTModelById(string id)
        {
            return null;
        }
    }
}