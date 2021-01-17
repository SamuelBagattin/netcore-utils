
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// HttpVersionNotSupported exception
    /// <see cref="System.Net.HttpStatusCode.HttpVersionNotSupported"/>
    /// </summary>
    public class HttpVersionNotSupportedException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.HttpVersionNotSupported;

        /// <summary>
        /// Initializes a new instance of <see cref="HttpVersionNotSupportedException"/>
        /// </summary>
        public HttpVersionNotSupportedException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="HttpVersionNotSupportedException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public HttpVersionNotSupportedException(string message) : base(message){ }
    }
}
