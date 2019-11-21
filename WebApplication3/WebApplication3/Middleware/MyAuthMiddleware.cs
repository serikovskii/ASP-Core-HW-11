using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.DataAccess;

namespace WebApplication3.Middleware
{
    public class MyAuthMiddleware
    {
        private readonly RequestDelegate requestDelegate;
        private readonly Context dbContext;

        public MyAuthMiddleware(RequestDelegate requestDelegate, Context dbContext)
        {
            this.requestDelegate = requestDelegate;
            this.dbContext = dbContext;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var myHeaderKey = context.Request.Headers["My-HeaderKey"].ToString();
            if (context.Request.Path == "api/auth/" || dbContext.Users.FirstOrDefault(key => key.MyHeaderKey == myHeaderKey) != null)
            {
                await requestDelegate(context);
            }
            else
                await context.Response.WriteAsync("Пользователь не авторизован");
        }
    }
}
