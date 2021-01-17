
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// RequestTimeout exception
    /// <see cref="System.Net.HttpStatusCode.RequestTimeout"/>
    /// </summary>
    public class RequestTimeoutException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.RequestTimeout;

        /// <summary>
        /// Initializes a new instance of <see cref="RequestTimeoutException"/>
        /// </summary>
        public RequestTimeoutException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="RequestTimeoutException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public RequestTimeoutException(string message) : base(message){ }
    }
}
