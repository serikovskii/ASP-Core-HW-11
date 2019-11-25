using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
            return Content(user.Id +  " - id " + user.MyHeaderKey + " - Key" );
        } 
    }
}