
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// BadGateway exception
    /// <see cref="System.Net.HttpStatusCode.BadGateway"/>
    /// </summary>
    public class BadGatewayException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.BadGateway;

        /// <summary>
        /// Initializes a new instance of <see cref="BadGatewayException"/>
        /// </summary>
        public BadGatewayException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="BadGatewayException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public BadGatewayException(string message) : base(message){ }
    }
}
