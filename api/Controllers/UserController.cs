using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        ApiAppContext apiContext;
        public UserController(ApiAppContext context)
        {
            apiContext = context;
            apiContext.Database.EnsureCreated();
        }
       
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return apiContext.Users.Where(p=> p.Active).ToList();
        }

        [HttpGet("{id}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]        
        public ActionResult<User> Get(string id)
        {

           Guid.TryParse(id, out var userId);

           if(userId != Guid.Empty)
           {
               var userFound  = apiContext.Users.FirstOrDefault(p=> p.UserId == userId);

                if(userFound!=null)
                    return Ok(userFound);
                else
                    return NotFound();
           }
           else
               return BadRequest();
        }

        [HttpPost]
        public async Task Post([FromBody] User value)
        {
            apiContext.Users.Add(value);
            await apiContext.SaveChangesAsync();
        }

        [HttpPut("{id}")]
        public void Put(string id, [FromBody] User value)
        {
           Guid.TryParse(id, out var userId);

           if(userId != Guid.Empty)
           {
               var userFound = apiContext.Users.FirstOrDefault(p=> p.UserId == userId);

               if(userFound!= null)
               {
                   userFound.Name = value.Name;
                   userFound.LastName = value.Name;
                   userFound.Active = value.Active;
                   apiContext.SaveChanges();
               }
           }
        }

        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            Guid.TryParse(id, out var userId);

           if(userId != Guid.Empty)
           {
               var userFound  = apiContext.Users.FirstOrDefault(p=> p.UserId == userId);

                apiContext.Users.Remove(userFound);
                await apiContext.SaveChangesAsync();
           }
        }
    }
}