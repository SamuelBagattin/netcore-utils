using System;

namespace DependencyInjection
{
    internal record Service
    {
        public Type Contract { get; init; }
        public Type Impl { get; init; }
        public ServiceType ServiceType { get; init; }
    }
}