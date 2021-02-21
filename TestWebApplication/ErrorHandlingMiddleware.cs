﻿using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace TestWebApplication
{
    public class ErrorHandlingMiddleware
    {
        private RequestDelegate _next;
        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            this._next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            await _next.Invoke(context);
            if (context.Response.StatusCode == 403)
            {
                await context.Response.WriteAsync("Access Denied");
            }
            else if (context.Response.StatusCode == 404)
            {
                await context.Response.WriteAsync("Not Found");
            }
        }
    }
}
