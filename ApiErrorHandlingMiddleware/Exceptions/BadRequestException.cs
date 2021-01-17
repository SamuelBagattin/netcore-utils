
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// BadRequest exception
    /// <see cref="System.Net.HttpStatusCode.BadRequest"/>
    /// </summary>
    public class BadRequestException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.BadRequest;

        /// <summary>
        /// Initializes a new instance of <see cref="BadRequestException"/>
        /// </summary>
        public BadRequestException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="BadRequestException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public BadRequestException(string message) : base(message){ }
    }
}
