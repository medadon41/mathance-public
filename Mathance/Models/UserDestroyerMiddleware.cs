using Mathance.Areas.Identity.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mathance.Models
{
    public class UserDestroyerMiddleware
    {
        private readonly RequestDelegate _next;

        public UserDestroyerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext,
            UserManager<MathanceUser> userManager,
            SignInManager<MathanceUser> signInManager)
        {

            if (!string.IsNullOrEmpty(httpContext.User.Identity.Name))
            {
                var user = await userManager.FindByNameAsync(httpContext.User.Identity.Name);
                if (user == null)
                {
                    await signInManager.SignOutAsync();
                    httpContext.Response.Redirect("/");
                }
                else
                {
                    if (user.IsBlocked && user.Id != null)
                    {
                        //Log the user out and redirect back to homepage
                        await signInManager.SignOutAsync();
                        httpContext.Response.Redirect("/");
                    }
                }
            }
            await _next(httpContext);
        }
    }

    public static class UserDestroyerMiddlewareExtensions
    {
        public static IApplicationBuilder UseUserDestroyer(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<UserDestroyerMiddleware>();
        }
    }
}
