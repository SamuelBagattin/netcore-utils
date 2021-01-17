
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// NetworkAuthenticationRequired exception
    /// <see cref="System.Net.HttpStatusCode.NetworkAuthenticationRequired"/>
    /// </summary>
    public class NetworkAuthenticationRequiredException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.NetworkAuthenticationRequired;

        /// <summary>
        /// Initializes a new instance of <see cref="NetworkAuthenticationRequiredException"/>
        /// </summary>
        public NetworkAuthenticationRequiredException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="NetworkAuthenticationRequiredException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public NetworkAuthenticationRequiredException(string message) : base(message){ }
    }
}
