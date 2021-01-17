
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// RequestedRangeNotSatisfiable exception
    /// <see cref="System.Net.HttpStatusCode.RequestedRangeNotSatisfiable"/>
    /// </summary>
    public class RequestedRangeNotSatisfiableException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.RequestedRangeNotSatisfiable;

        /// <summary>
        /// Initializes a new instance of <see cref="RequestedRangeNotSatisfiableException"/>
        /// </summary>
        public RequestedRangeNotSatisfiableException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="RequestedRangeNotSatisfiableException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public RequestedRangeNotSatisfiableException(string message) : base(message){ }
    }
}
