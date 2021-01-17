
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// PreconditionRequired exception
    /// <see cref="System.Net.HttpStatusCode.PreconditionRequired"/>
    /// </summary>
    public class PreconditionRequiredException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.PreconditionRequired;

        /// <summary>
        /// Initializes a new instance of <see cref="PreconditionRequiredException"/>
        /// </summary>
        public PreconditionRequiredException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="PreconditionRequiredException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public PreconditionRequiredException(string message) : base(message){ }
    }
}
