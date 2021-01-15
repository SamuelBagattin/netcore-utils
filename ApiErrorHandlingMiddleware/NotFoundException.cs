using System;

namespace ApiErrorHandlingMiddleware
{
    /// <summary>
    /// Not found exception
    /// </summary>
    public class NotFoundException : Exception
    {
        /// <summary>
        /// Initialize new instance of <see cref="NotFoundException"/>
        /// </summary>
        public NotFoundException()
        {

        }

        /// <summary>
        /// Initialize new instance of <see cref="NotFoundException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public NotFoundException(string message):base(message)
        {
        }
    }
}
