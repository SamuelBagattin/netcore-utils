
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// RequestHeaderFieldsTooLarge exception
    /// <see cref="System.Net.HttpStatusCode.RequestHeaderFieldsTooLarge"/>
    /// </summary>
    public class RequestHeaderFieldsTooLargeException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.RequestHeaderFieldsTooLarge;

        /// <summary>
        /// Initializes a new instance of <see cref="RequestHeaderFieldsTooLargeException"/>
        /// </summary>
        public RequestHeaderFieldsTooLargeException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="RequestHeaderFieldsTooLargeException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public RequestHeaderFieldsTooLargeException(string message) : base(message){ }
    }
}
