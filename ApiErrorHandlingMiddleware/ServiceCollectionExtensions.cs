using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace ApiErrorHandlingMiddleware
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterModelValidationHandling(this IServiceCollection serviceCollection)
        {
            serviceCollection.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = context =>
                    new BadRequestObjectResult(new ApiErrorModel
                    {
                        StatusCode = (int) HttpStatusCode.BadRequest,
                        Error = string.Join(" ",
                            context.ModelState.SelectMany(state =>
                                state.Value.Errors.Select(error => error.ErrorMessage)))
                    });
            });
            return serviceCollection;
        }
    }
}