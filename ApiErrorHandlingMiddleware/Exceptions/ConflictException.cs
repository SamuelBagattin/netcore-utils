
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// Conflict exception
    /// <see cref="System.Net.HttpStatusCode.Conflict"/>
    /// </summary>
    public class ConflictException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.Conflict;

        /// <summary>
        /// Initializes a new instance of <see cref="ConflictException"/>
        /// </summary>
        public ConflictException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="ConflictException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public ConflictException(string message) : base(message){ }
    }
}
