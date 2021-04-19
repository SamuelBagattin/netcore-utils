using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Net;
using DependencyInjection.Exceptions;

namespace DependencyInjection
{
    public class DiContainer
    {
        private readonly Dictionary<Type, Service> _services;

        private readonly Dictionary<Type, object> _singletons = new();

        internal DiContainer(Dictionary<Type, Service> services)
        {
            _services = services;
        }

        public T GetRequiredService<T>()
        {
            return (T) GetServiceFromType(typeof(T));
        }

        private object GetServiceFromType(Type type)
        {
            var currentSvc = _services[type];
            foreach (var constructorInfo in currentSvc.Impl.GetConstructors())
            {
                var parametersTypes = constructorInfo.GetParameters().Select(param => param.ParameterType).ToImmutableArray();
                var isInjectable = parametersTypes.All(param => _services.Any(service => service.Key == param));
                
                if (!isInjectable) continue;
                
                var paramsInstances = parametersTypes.Select(GetServiceFromType).ToArray();
                switch (currentSvc.ServiceType)
                {
                    case ServiceType.Singleton:
                        if (!_singletons.ContainsKey(currentSvc.Contract))
                        {
                            _singletons[currentSvc.Contract] = parametersTypes.Any()
                            ? ReflectionUtils.CreateInstanceOf(currentSvc.Impl, paramsInstances)
                            : ReflectionUtils.CreateInstanceOf(currentSvc.Impl);
                        }
                        return _singletons[currentSvc.Contract];
                    case ServiceType.Transient:
                        return parametersTypes.Any()
                            ? ReflectionUtils.CreateInstanceOf(currentSvc.Impl, paramsInstances)
                            : ReflectionUtils.CreateInstanceOf(currentSvc.Impl);
                    default:
                        throw new ArgumentOutOfRangeException(nameof(currentSvc.ServiceType));
                }
                
            }

            throw new ConstructorNotFoundException($"No suitable constructor found for type {type.FullName}");
        }
    }
}