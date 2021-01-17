
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// MisdirectedRequest exception
    /// <see cref="System.Net.HttpStatusCode.MisdirectedRequest"/>
    /// </summary>
    public class MisdirectedRequestException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.MisdirectedRequest;

        /// <summary>
        /// Initializes a new instance of <see cref="MisdirectedRequestException"/>
        /// </summary>
        public MisdirectedRequestException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="MisdirectedRequestException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public MisdirectedRequestException(string message) : base(message){ }
    }
}
