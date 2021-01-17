
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// GatewayTimeout exception
    /// <see cref="System.Net.HttpStatusCode.GatewayTimeout"/>
    /// </summary>
    public class GatewayTimeoutException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.GatewayTimeout;

        /// <summary>
        /// Initializes a new instance of <see cref="GatewayTimeoutException"/>
        /// </summary>
        public GatewayTimeoutException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="GatewayTimeoutException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public GatewayTimeoutException(string message) : base(message){ }
    }
}
