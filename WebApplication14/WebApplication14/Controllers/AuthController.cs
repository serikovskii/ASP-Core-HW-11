using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication14.DataAccess;
using WebApplication14.Models;

namespace WebApplication14.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserContext userContext;

        public AuthController(UserContext userContext)
        {
            this.userContext = userContext;
        }
        [HttpPost]
        public async Task<ActionResult<User>> AddUser(User user)
        {
            userContext.Users.Add(user);
            await userContext.SaveChangesAsync();
            return Content(user.MyHeaderKey);
        } 

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await userContext.Users.ToListAsync();
        }
    }
}