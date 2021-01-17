
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// InsufficientStorage exception
    /// <see cref="System.Net.HttpStatusCode.InsufficientStorage"/>
    /// </summary>
    public class InsufficientStorageException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.InsufficientStorage;

        /// <summary>
        /// Initializes a new instance of <see cref="InsufficientStorageException"/>
        /// </summary>
        public InsufficientStorageException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="InsufficientStorageException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public InsufficientStorageException(string message) : base(message){ }
    }
}
