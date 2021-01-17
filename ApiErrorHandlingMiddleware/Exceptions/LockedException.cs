
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// Locked exception
    /// <see cref="System.Net.HttpStatusCode.Locked"/>
    /// </summary>
    public class LockedException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.Locked;

        /// <summary>
        /// Initializes a new instance of <see cref="LockedException"/>
        /// </summary>
        public LockedException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="LockedException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public LockedException(string message) : base(message){ }
    }
}
