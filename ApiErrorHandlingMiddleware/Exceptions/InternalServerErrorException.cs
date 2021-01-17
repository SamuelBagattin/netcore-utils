
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// InternalServerError exception
    /// <see cref="System.Net.HttpStatusCode.InternalServerError"/>
    /// </summary>
    public class InternalServerErrorException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.InternalServerError;

        /// <summary>
        /// Initializes a new instance of <see cref="InternalServerErrorException"/>
        /// </summary>
        public InternalServerErrorException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="InternalServerErrorException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public InternalServerErrorException(string message) : base(message){ }
    }
}
