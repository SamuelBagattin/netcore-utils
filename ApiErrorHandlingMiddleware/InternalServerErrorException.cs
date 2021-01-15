using System;

namespace ApiErrorHandlingMiddleware
{
    /// <summary>
    /// InternalServerErrorException exception
    /// </summary>
    public class InternalServerErrorException : Exception
    {
        /// <summary>
        /// Initialize new instance of <see cref="InternalServerErrorException"/>
        /// </summary>
        public InternalServerErrorException()
        {

        }

        /// <summary>
        /// Initialize new instance of <see cref="InternalServerErrorException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public InternalServerErrorException(string message) : base(message)
        {
        }
    }
}
