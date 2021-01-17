
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// RequestEntityTooLarge exception
    /// <see cref="System.Net.HttpStatusCode.RequestEntityTooLarge"/>
    /// </summary>
    public class RequestEntityTooLargeException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.RequestEntityTooLarge;

        /// <summary>
        /// Initializes a new instance of <see cref="RequestEntityTooLargeException"/>
        /// </summary>
        public RequestEntityTooLargeException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="RequestEntityTooLargeException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public RequestEntityTooLargeException(string message) : base(message){ }
    }
}
