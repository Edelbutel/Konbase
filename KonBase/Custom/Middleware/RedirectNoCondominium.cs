using KonBase.Models;
using KonBase.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonBase.Custom.Middleware
{
    public class RedirectNoCondominium
    {
        private readonly RequestDelegate _next;
        private readonly string path = "/Condominium/Add";

        public RedirectNoCondominium(RequestDelegate next)
        {
            _next = next;
        }


        public async Task Invoke(HttpContext httpContext,UserManager<ApplicationUsers> _userManager, ICondominiumService _condominiumManager)
        {
            if (httpContext.User.Identity.IsAuthenticated)
            {
                ApplicationUsers user = await _userManager.GetUserAsync(httpContext.User);

                if (user != null)
                {

                    var retorno = await _condominiumManager.GetCondominiumByIdAsync(user.Id);

                    if (retorno.Count == 0 && httpContext.Request.Path.Value != path)
                    {
                        httpContext.Response.Redirect(path);
                    }
                    else
                    {

                        await _next(httpContext);
                    }
                }
                else
                {
                    await _next(httpContext);
                }
            }
            else
            {
                await _next(httpContext);
            }
        }
    }
}
