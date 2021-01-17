
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// UnavailableForLegalReasons exception
    /// <see cref="System.Net.HttpStatusCode.UnavailableForLegalReasons"/>
    /// </summary>
    public class UnavailableForLegalReasonsException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.UnavailableForLegalReasons;

        /// <summary>
        /// Initializes a new instance of <see cref="UnavailableForLegalReasonsException"/>
        /// </summary>
        public UnavailableForLegalReasonsException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="UnavailableForLegalReasonsException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public UnavailableForLegalReasonsException(string message) : base(message){ }
    }
}
