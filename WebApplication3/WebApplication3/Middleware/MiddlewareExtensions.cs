using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Middleware
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseMyAuth(this IApplicationBuilder app)
        {
            return app.UseMiddleware<MyAuthMiddleware>();
        }
    }
}
