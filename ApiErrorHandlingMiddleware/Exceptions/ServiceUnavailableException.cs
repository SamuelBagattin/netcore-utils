
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// ServiceUnavailable exception
    /// <see cref="System.Net.HttpStatusCode.ServiceUnavailable"/>
    /// </summary>
    public class ServiceUnavailableException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.ServiceUnavailable;

        /// <summary>
        /// Initializes a new instance of <see cref="ServiceUnavailableException"/>
        /// </summary>
        public ServiceUnavailableException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="ServiceUnavailableException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public ServiceUnavailableException(string message) : base(message){ }
    }
}
