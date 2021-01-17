
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// UnprocessableEntity exception
    /// <see cref="System.Net.HttpStatusCode.UnprocessableEntity"/>
    /// </summary>
    public class UnprocessableEntityException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.UnprocessableEntity;

        /// <summary>
        /// Initializes a new instance of <see cref="UnprocessableEntityException"/>
        /// </summary>
        public UnprocessableEntityException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="UnprocessableEntityException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public UnprocessableEntityException(string message) : base(message){ }
    }
}
