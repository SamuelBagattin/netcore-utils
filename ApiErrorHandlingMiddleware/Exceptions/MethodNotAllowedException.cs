
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// MethodNotAllowed exception
    /// <see cref="System.Net.HttpStatusCode.MethodNotAllowed"/>
    /// </summary>
    public class MethodNotAllowedException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.MethodNotAllowed;

        /// <summary>
        /// Initializes a new instance of <see cref="MethodNotAllowedException"/>
        /// </summary>
        public MethodNotAllowedException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="MethodNotAllowedException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public MethodNotAllowedException(string message) : base(message){ }
    }
}
