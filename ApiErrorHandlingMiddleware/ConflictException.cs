using System;

namespace ApiErrorHandlingMiddleware
{
    /// <summary>
    /// Conflict exception
    /// </summary>
    public class ConflictException : Exception
    {
        /// <summary>
        /// Initialize new instance of <see cref="ConflictException"/>
        /// </summary>
        public ConflictException()
        {

        }

        /// <summary>
        /// Initialize new instance of <see cref="ConflictException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public ConflictException(string message) : base(message)
        {
        }
    }
}
