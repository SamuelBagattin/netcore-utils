
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// Gone exception
    /// <see cref="System.Net.HttpStatusCode.Gone"/>
    /// </summary>
    public class GoneException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.Gone;

        /// <summary>
        /// Initializes a new instance of <see cref="GoneException"/>
        /// </summary>
        public GoneException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="GoneException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public GoneException(string message) : base(message){ }
    }
}
