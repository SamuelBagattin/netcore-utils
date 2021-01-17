
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// NotImplemented exception
    /// <see cref="System.Net.HttpStatusCode.NotImplemented"/>
    /// </summary>
    public class NotImplementedException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.NotImplemented;

        /// <summary>
        /// Initializes a new instance of <see cref="NotImplementedException"/>
        /// </summary>
        public NotImplementedException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="NotImplementedException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public NotImplementedException(string message) : base(message){ }
    }
}
