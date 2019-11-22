using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;
using WebApplication14.DataAccess;

namespace WebApplication14.Middleware
{
    public class MyAuthMiddleware
    {
        private readonly RequestDelegate requestDelegate;
        private readonly UserContext userContext;

        public MyAuthMiddleware(RequestDelegate requestDelegate, UserContext userContext)
        {
            this.requestDelegate = requestDelegate;
            this.userContext = userContext;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var myHeaderKey = context.Request.Headers["My-HeaderKey"].ToString();
            if (context.Request.Path == "api/auth/" || userContext.Users.FirstOrDefault(key => key.MyHeaderKey == myHeaderKey) != null)
            {
                await requestDelegate(context);
            }
            else
                await context.Response.WriteAsync("Пользователь не авторизован");
        }
    }
}
