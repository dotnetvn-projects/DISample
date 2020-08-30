using DISample.DIContainer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DISample
{
    class MyDIContainer : IDIContainer
    {
        Dictionary<Type, Func<object>> registrations = new Dictionary<Type, Func<object>>();

        public void Register<TService, TImpl>() where TImpl : TService
        {
            registrations.Add(typeof(TService), () => GetInstance(typeof(TImpl)));
        }

        public void Register<TService>(Func<TService> instanceCreator)
        {
            registrations.Add(typeof(TService), () => instanceCreator());
        }

        public void RegisterSingleton<TService>(TService instance)
        {
            registrations.Add(typeof(TService), () => instance);
        }

        public void RegisterSingleton<TService>(Func<TService> instanceCreator)
        {
            var lazy = new Lazy<TService>(instanceCreator);
            Register(() => lazy.Value);
        }

        public TService Resolve<TService>()
        {
            return (TService)GetInstance(typeof(TService));
        }

        private object GetInstance(Type serviceType)
        {
            Func<object> creator;

            if (registrations.TryGetValue(serviceType, out creator))
            {
                return creator();
            }
            else if (!serviceType.IsAbstract)
            {
                return CreateInstance(serviceType);
            }
            
           throw new InvalidOperationException("No registration for " + serviceType);
        }

        private object CreateInstance(Type implementationType)
        {
            var ctor = implementationType.GetConstructors().Single();
            var parameterTypes = ctor.GetParameters().Select(p => p.ParameterType);
            var dependencies = parameterTypes.Select(t => GetInstance(t)).ToArray();

            return Activator.CreateInstance(implementationType, dependencies);
        }
    }
}
