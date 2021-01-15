using System;

namespace ApiErrorHandlingMiddleware
{
    /// <summary>
    /// UnprocessableEntityException exception
    /// </summary>
    public class UnprocessableEntityException : Exception
    {
        /// <summary>
        /// Initialize new instance of <see cref="UnprocessableEntityException"/>
        /// </summary>
        public UnprocessableEntityException()
        {

        }

        /// <summary>
        /// Initialize new instance of <see cref="UnprocessableEntityException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public UnprocessableEntityException(string message) : base(message)
        {
        }
    }
}
