using System;

namespace DependencyInjection
{
    internal static class ReflectionUtils
    {
        public static object CreateInstanceOf(Type type, object[] parameters) => Activator.CreateInstance(type, args: parameters);
        public static object CreateInstanceOf(Type type) => Activator.CreateInstance(type);
    }
}