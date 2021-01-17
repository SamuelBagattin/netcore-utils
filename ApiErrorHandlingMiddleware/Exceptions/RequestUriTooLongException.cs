
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// RequestUriTooLong exception
    /// <see cref="System.Net.HttpStatusCode.RequestUriTooLong"/>
    /// </summary>
    public class RequestUriTooLongException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.RequestUriTooLong;

        /// <summary>
        /// Initializes a new instance of <see cref="RequestUriTooLongException"/>
        /// </summary>
        public RequestUriTooLongException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="RequestUriTooLongException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public RequestUriTooLongException(string message) : base(message){ }
    }
}
