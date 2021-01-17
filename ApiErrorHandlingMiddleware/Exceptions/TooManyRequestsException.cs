
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// TooManyRequests exception
    /// <see cref="System.Net.HttpStatusCode.TooManyRequests"/>
    /// </summary>
    public class TooManyRequestsException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.TooManyRequests;

        /// <summary>
        /// Initializes a new instance of <see cref="TooManyRequestsException"/>
        /// </summary>
        public TooManyRequestsException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="TooManyRequestsException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public TooManyRequestsException(string message) : base(message){ }
    }
}
