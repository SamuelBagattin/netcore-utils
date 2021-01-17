
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// Unauthorized exception
    /// <see cref="System.Net.HttpStatusCode.Unauthorized"/>
    /// </summary>
    public class UnauthorizedException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.Unauthorized;

        /// <summary>
        /// Initializes a new instance of <see cref="UnauthorizedException"/>
        /// </summary>
        public UnauthorizedException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="UnauthorizedException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public UnauthorizedException(string message) : base(message){ }
    }
}
