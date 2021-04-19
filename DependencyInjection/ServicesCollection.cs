using System;
using System.Collections.Generic;
using System.Linq;

namespace DependencyInjection
{
    public class ServicesCollection
    {
        private readonly HashSet<Service> _services = new();

        public ServicesCollection AddTransient<TContract, TImpl>() 
            where TImpl : class, TContract 
        {
            Add<TContract, TImpl>(ServiceType.Transient);
            return this;
        }

        public ServicesCollection AddSingleton<TContract, TImpl>()
            where TImpl : class, TContract
        {
            Add<TContract, TImpl>(ServiceType.Singleton);
            return this;
        }

        private void Add<TContract, TImpl>(ServiceType serviceType) 
            where TImpl : class, TContract
        {
            _services.Add(new Service
            {
                Contract = typeof(TContract),
                Impl = typeof(TImpl),
                ServiceType = serviceType
            }); 
        }

        public DiContainer Build() => new(_services.ToDictionary(key => key.Contract, val => val));
    }
}