using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WebAPI_Practices.Middleware
{
    public class CustomExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILoggerService _logger;

        public CustomExceptionMiddleware(RequestDelegate next, ILoggerService logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                string message = "[Request] HTTP-" + context.Request.Method + "-" + context.Request.Path;
                _logger.Log(message);

                await _next(context);

                message = "[Response] HTTP-" + context.Request.Method + "- " + context.Request.Path + " responded " +
                          context.Response.StatusCode;

                _logger.Log(message);

            }
            catch (Exception ex)
            {
                await HandleException(context, ex);
            }

        }
        private Task HandleException(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            string message = "[Error]   HTTP " + context.Request.Method + " - " + context.Response.StatusCode +
                             "Error Message : " + ex.Message;
            _logger.Log(message);

            var result = JsonConvert.SerializeObject(new { error = ex.Message });

            return context.Response.WriteAsync(result);
        }
    }
    public static class CustomExceptionMiddlewareExtension
    {
        public static IApplicationBuilder UseCustomeExceptionMiddle(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomExceptionMiddleware>();
        }
    }
}
