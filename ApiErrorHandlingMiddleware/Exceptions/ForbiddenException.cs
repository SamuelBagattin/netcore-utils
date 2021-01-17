
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// Forbidden exception
    /// <see cref="System.Net.HttpStatusCode.Forbidden"/>
    /// </summary>
    public class ForbiddenException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.Forbidden;

        /// <summary>
        /// Initializes a new instance of <see cref="ForbiddenException"/>
        /// </summary>
        public ForbiddenException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="ForbiddenException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public ForbiddenException(string message) : base(message){ }
    }
}
