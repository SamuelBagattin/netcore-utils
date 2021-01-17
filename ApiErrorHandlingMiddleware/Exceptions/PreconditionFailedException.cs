
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// PreconditionFailed exception
    /// <see cref="System.Net.HttpStatusCode.PreconditionFailed"/>
    /// </summary>
    public class PreconditionFailedException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.PreconditionFailed;

        /// <summary>
        /// Initializes a new instance of <see cref="PreconditionFailedException"/>
        /// </summary>
        public PreconditionFailedException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="PreconditionFailedException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public PreconditionFailedException(string message) : base(message){ }
    }
}
