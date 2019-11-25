using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication14.DataAccess;
using WebApplication14.Models;

namespace WebApplication14.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly UserContext userContext;

        public ServiceController(UserContext userContext)
        {
            this.userContext = userContext;
        }

        [HttpGet()]
        public async Task <ActionResult<User>> GetUser([FromQuery(Name = "id")] Guid id)
        {
            var oneUser = await userContext.Users.FindAsync(id);
            if(oneUser == null)
            {
                return NotFound();
            }
            return oneUser;
        }
    }
}