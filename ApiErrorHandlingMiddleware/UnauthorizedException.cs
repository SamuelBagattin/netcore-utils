using System;

namespace ApiErrorHandlingMiddleware
{
    /// <summary>
    /// UnauthorizedException exception
    /// </summary>
    public class UnauthorizedException : Exception
    {
        /// <summary>
        /// Initialize new instance of <see cref="UnauthorizedException"/>
        /// </summary>
        public UnauthorizedException()
        {

        }

        /// <summary>
        /// Initialize new instance of <see cref="UnauthorizedException"/>
        /// </summary>
        /// <param name="message">Error message</param>
        public UnauthorizedException(string message) : base(message)
        {
            
        }
    }
}
