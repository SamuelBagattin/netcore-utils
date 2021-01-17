
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// UpgradeRequired exception
    /// <see cref="System.Net.HttpStatusCode.UpgradeRequired"/>
    /// </summary>
    public class UpgradeRequiredException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.UpgradeRequired;

        /// <summary>
        /// Initializes a new instance of <see cref="UpgradeRequiredException"/>
        /// </summary>
        public UpgradeRequiredException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="UpgradeRequiredException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public UpgradeRequiredException(string message) : base(message){ }
    }
}
