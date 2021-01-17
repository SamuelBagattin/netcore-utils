
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// ProxyAuthenticationRequired exception
    /// <see cref="System.Net.HttpStatusCode.ProxyAuthenticationRequired"/>
    /// </summary>
    public class ProxyAuthenticationRequiredException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.ProxyAuthenticationRequired;

        /// <summary>
        /// Initializes a new instance of <see cref="ProxyAuthenticationRequiredException"/>
        /// </summary>
        public ProxyAuthenticationRequiredException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="ProxyAuthenticationRequiredException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public ProxyAuthenticationRequiredException(string message) : base(message){ }
    }
}
