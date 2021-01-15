using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace ApiErrorHandlingMiddleware
{
        public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate next;

        /// <summary>
        /// Initialize new instance of the <see cref="ErrorHandlingMiddleware"/>
        /// </summary>
        /// <param name="next"></param>
        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        /// <summary>
        /// Invoke request
        /// </summary>
        /// <param name="context">Http context</param>
        public async Task Invoke(HttpContext context /* other dependencies */)
        {
            try
            {
                await next(context);
            }
            catch (NotFoundException ex)
            {
                await HandleExceptionAsync(context, HttpStatusCode.NotFound, ex);
            }
            catch (UnauthorizedException)
            {
                await HandleExceptionAsync(context, HttpStatusCode.Unauthorized);
            }
            catch (ConflictException ex)
            {
                await HandleExceptionAsync(context, HttpStatusCode.Conflict, ex);
            }
            catch (BadRequestException ex)
            {
                await HandleExceptionAsync(context, HttpStatusCode.BadRequest, ex);
            }
            catch (InternalServerErrorException ex)
            {
                await HandleExceptionAsync(context, HttpStatusCode.InternalServerError, ex);
            }
            catch (UnprocessableEntityException ex)
            {
                await HandleExceptionAsync(context, HttpStatusCode.UnprocessableEntity, ex);
            }
        }

        /// <summary>
        /// Manage specific request exceptions
        /// </summary>
        /// <param name="context">Http context</param>
        /// <param name="httpCode">Http error code</param>
        /// <param name="exception">Exception</param>
        /// <returns>Response</returns>
        private static Task HandleExceptionAsync(HttpContext context, HttpStatusCode httpCode, Exception exception = null)
        {
            var result = string.Empty;
            if (exception != null)
            {
                result = JsonConvert.SerializeObject(new ApiErrorModel{Error = exception.Message});
            }

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)httpCode;
            return context.Response.WriteAsync(result);
        }
    }
        /// <summary>
        /// Model used to return errors from github manager api
        /// </summary>
        public class ApiErrorModel
        {
            /// <summary>
            /// Value of the error in api model.
            /// </summary>
            public string Error { get; set; }
        }
}