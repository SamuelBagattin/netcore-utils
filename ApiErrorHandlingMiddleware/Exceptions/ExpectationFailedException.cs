
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// ExpectationFailed exception
    /// <see cref="System.Net.HttpStatusCode.ExpectationFailed"/>
    /// </summary>
    public class ExpectationFailedException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.ExpectationFailed;

        /// <summary>
        /// Initializes a new instance of <see cref="ExpectationFailedException"/>
        /// </summary>
        public ExpectationFailedException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="ExpectationFailedException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public ExpectationFailedException(string message) : base(message){ }
    }
}
