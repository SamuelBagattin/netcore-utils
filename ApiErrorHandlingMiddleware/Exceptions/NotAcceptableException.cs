
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// NotAcceptable exception
    /// <see cref="System.Net.HttpStatusCode.NotAcceptable"/>
    /// </summary>
    public class NotAcceptableException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.NotAcceptable;

        /// <summary>
        /// Initializes a new instance of <see cref="NotAcceptableException"/>
        /// </summary>
        public NotAcceptableException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="NotAcceptableException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public NotAcceptableException(string message) : base(message){ }
    }
}
