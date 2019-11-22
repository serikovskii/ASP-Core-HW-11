using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;
using WebApplication14.DataAccess;

namespace WebApplication14.Middleware
{
    public class MyAuthMiddleware
    {
        private readonly RequestDelegate requestDelegate;

        public MyAuthMiddleware(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            UserContext userContext = context.RequestServices.GetService(typeof(UserContext)) as UserContext;
            var myHeaderKey = context.Request.Headers["MyHeaderKey"].ToString();
            var path = context.Request.Path.ToString();
            var users = userContext.Users.FirstOrDefault(key => key.MyHeaderKey == myHeaderKey);
            if (path == "/api/auth" || users != null) // 
            {
                await requestDelegate(context);
            }
            else
                await context.Response.WriteAsync("Пользователь не авторизован");
        }
    }
}
