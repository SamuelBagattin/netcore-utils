
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// VariantAlsoNegotiates exception
    /// <see cref="System.Net.HttpStatusCode.VariantAlsoNegotiates"/>
    /// </summary>
    public class VariantAlsoNegotiatesException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.VariantAlsoNegotiates;

        /// <summary>
        /// Initializes a new instance of <see cref="VariantAlsoNegotiatesException"/>
        /// </summary>
        public VariantAlsoNegotiatesException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="VariantAlsoNegotiatesException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public VariantAlsoNegotiatesException(string message) : base(message){ }
    }
}
