using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WebAPI.Middlewares
{
    public class WebAPIMiddleware
    {
        private readonly RequestDelegate _next;

        public WebAPIMiddleware(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                // Add middleware here

            }
            catch (Exception ex)
            {
                await HandleError(context, ex.Message);
            }
        }

        /// <summary>
        /// Middleware Error handler
        /// </summary>
        /// <param name="context">Http Context</param>
        /// <param name="ex">Exception Message</param>
        /// <returns></returns>
        public static Task HandleError(HttpContext context, string ex)
        {
            HttpStatusCode code = HttpStatusCode.InternalServerError; // 500 if unexpected


            string result = JsonConvert.SerializeObject(new { error = ex });

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;

            return context.Response.WriteAsync(result);
        }
    }

    public static class WebAPIMiddlewareExtension
    {
        // Rename this method at will
        public static IApplicationBuilder UseWebAPI(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<WebAPIMiddleware>();
        }
    }
}
