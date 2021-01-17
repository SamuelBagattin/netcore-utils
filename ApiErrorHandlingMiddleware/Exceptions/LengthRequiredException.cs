
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// LengthRequired exception
    /// <see cref="System.Net.HttpStatusCode.LengthRequired"/>
    /// </summary>
    public class LengthRequiredException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.LengthRequired;

        /// <summary>
        /// Initializes a new instance of <see cref="LengthRequiredException"/>
        /// </summary>
        public LengthRequiredException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="LengthRequiredException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public LengthRequiredException(string message) : base(message){ }
    }
}
