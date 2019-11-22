using Microsoft.AspNetCore.Builder;

namespace WebApplication14.Middleware
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseMyAuth(this IApplicationBuilder app)
        {
            return app.UseMiddleware<MyAuthMiddleware>();
        }
    }
}
