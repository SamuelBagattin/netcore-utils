
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// NotFound exception
    /// <see cref="System.Net.HttpStatusCode.NotFound"/>
    /// </summary>
    public class NotFoundException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.NotFound;

        /// <summary>
        /// Initializes a new instance of <see cref="NotFoundException"/>
        /// </summary>
        public NotFoundException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="NotFoundException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public NotFoundException(string message) : base(message){ }
    }
}
