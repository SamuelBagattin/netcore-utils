
using System;
using System.Net;
namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// LoopDetected exception
    /// <see cref="System.Net.HttpStatusCode.LoopDetected"/>
    /// </summary>
    public class LoopDetectedException : BaseException
    {

        internal override HttpStatusCode HttpStatusCode => HttpStatusCode.LoopDetected;

        /// <summary>
        /// Initializes a new instance of <see cref="LoopDetectedException"/>
        /// </summary>
        public LoopDetectedException() { }

        /// <summary>
        /// Initializes a new instance of <see cref="LoopDetectedException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public LoopDetectedException(string message) : base(message){ }
    }
}
