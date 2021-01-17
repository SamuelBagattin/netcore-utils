using System;
using System.Net;
using System.Threading.Tasks;
using ApiErrorHandlingMiddleware.Exceptions;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace ApiErrorHandlingMiddleware
{
    internal class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        /// <summary>
        /// Initialize new instance of the <see cref="ErrorHandlingMiddleware"/>
        /// </summary>
        /// <param name="next"></param>
        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        /// <summary>
        /// Invoke request
        /// </summary>
        /// <param name="context">Http context</param>
        public async Task Invoke(HttpContext context /* other dependencies */)
        {
            try
            {
                await _next(context);
            }
            catch (BaseException ex)
            {
                await HandleBaseExceptionAsync(context, ex.HttpStatusCode, ex);
            }
            catch (Exception)
            {
                await HandleExceptionAsync(context);
            }
        }

        /// <summary>
        /// Manage specific request exceptions
        /// </summary>
        /// <param name="context">Http context</param>
        /// <param name="httpCode">Http error code</param>
        /// <param name="exception">Exception</param>
        /// <returns>Response</returns>
        private static Task HandleBaseExceptionAsync(
            HttpContext context,
            HttpStatusCode httpCode,
            Exception exception = null
        )
        {
            var result = string.Empty;
            if (exception != null)
            {
                result = JsonConvert.SerializeObject(new ApiErrorModel
                    {StatusCode = (ushort) httpCode, Error = exception.Message});
            }

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int) httpCode;
            return context.Response.WriteAsync(result);
        }

        private static Task HandleExceptionAsync(HttpContext context)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int) HttpStatusCode.InternalServerError;
            return context.Response.WriteAsync(
                JsonConvert.SerializeObject(
                    new ApiErrorModel
                    {
                        StatusCode = 500,
                        Error = "Internal Server Error"
                    }
                )
            );
        }
    }

    /// <summary>
    /// Model used to return errors the api
    /// </summary>
    public class ApiErrorModel
    {
        /// <summary>
        /// Http status code of the exception
        /// </summary>
        public ushort StatusCode { get; set; }

        /// <summary>
        /// Value of the error in api model.
        /// </summary>
        public string Error { get; set; }
    }
}