using System;

namespace ApiErrorHandlingMiddleware
{
    /// <summary>
    /// BadRequestException exception
    /// </summary>
    public class BadRequestException : Exception
    {
        /// <summary>
        /// Initialize new instance of <see cref="BadRequestException"/>
        /// </summary>
        public BadRequestException()
        {

        }

        /// <summary>
        /// Initialize new instance of <see cref="BadRequestException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public BadRequestException(string message) : base(message)
        {
        }
    }
}
