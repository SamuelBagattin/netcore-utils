using System;

namespace DependencyInjection.Exceptions
{
    public class ConstructorNotFoundException : Exception
    {
        public ConstructorNotFoundException(string message) : base(message)
        {
        }
    }
}