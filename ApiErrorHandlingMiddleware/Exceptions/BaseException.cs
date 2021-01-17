using System;
using System.Net;

namespace ApiErrorHandlingMiddleware.Exceptions
{
    /// <summary>
    /// Common base of all exceptions of the middleware
    /// </summary>
    public abstract class BaseException : Exception
    {
        /// <summary>
        /// Http status code of the exception
        /// </summary>
        internal abstract HttpStatusCode HttpStatusCode { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        protected BaseException(){}
        
        /// <summary>
        /// Constructor with error message
        /// </summary>
        /// <param name="message">Error message</param>
        protected BaseException(string message) : base(message)
        {
            
        }
        
    }
}