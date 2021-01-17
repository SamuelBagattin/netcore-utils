
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// NotExtended exception
    /// <see cref="System.Net.HttpStatusCode.NotExtended"/>
    /// </summary>
    public class NotExtendedException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.NotExtended;

        /// <summary>
        /// Initializes a new instance of <see cref="NotExtendedException"/>
        /// </summary>
        public NotExtendedException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="NotExtendedException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public NotExtendedException(string message) : base(message){ }
    }
}
