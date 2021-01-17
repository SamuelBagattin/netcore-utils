
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// UnsupportedMediaType exception
    /// <see cref="System.Net.HttpStatusCode.UnsupportedMediaType"/>
    /// </summary>
    public class UnsupportedMediaTypeException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.UnsupportedMediaType;

        /// <summary>
        /// Initializes a new instance of <see cref="UnsupportedMediaTypeException"/>
        /// </summary>
        public UnsupportedMediaTypeException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="UnsupportedMediaTypeException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public UnsupportedMediaTypeException(string message) : base(message){ }
    }
}
