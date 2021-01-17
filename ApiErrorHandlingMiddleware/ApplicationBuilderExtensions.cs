using Microsoft.AspNetCore.Builder;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ApiErrorHandlingMiddleware
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder RegisterErrorHandlingMiddleware(this IApplicationBuilder applicationBuilder)
        {
            applicationBuilder.UseMiddleware<ErrorHandlingMiddleware>();
            return applicationBuilder;
        }
    }
}