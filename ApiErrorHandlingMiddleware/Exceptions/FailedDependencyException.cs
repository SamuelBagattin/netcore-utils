
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// FailedDependency exception
    /// <see cref="System.Net.HttpStatusCode.FailedDependency"/>
    /// </summary>
    public class FailedDependencyException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.FailedDependency;

        /// <summary>
        /// Initializes a new instance of <see cref="FailedDependencyException"/>
        /// </summary>
        public FailedDependencyException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="FailedDependencyException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public FailedDependencyException(string message) : base(message){ }
    }
}
