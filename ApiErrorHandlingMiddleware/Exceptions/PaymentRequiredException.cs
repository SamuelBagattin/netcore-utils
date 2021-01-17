
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// PaymentRequired exception
    /// <see cref="System.Net.HttpStatusCode.PaymentRequired"/>
    /// </summary>
    public class PaymentRequiredException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.PaymentRequired;

        /// <summary>
        /// Initializes a new instance of <see cref="PaymentRequiredException"/>
        /// </summary>
        public PaymentRequiredException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="PaymentRequiredException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public PaymentRequiredException(string message) : base(message){ }
    }
}
