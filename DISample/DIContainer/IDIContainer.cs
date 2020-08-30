using System;

namespace DISample.DIContainer
{
    public interface IDIContainer
    {
        void Register<TService, TImpl>() where TImpl : TService;

        void Register<TService>(Func<TService> instanceCreator);

        void RegisterSingleton<TService>(TService instance);

        void RegisterSingleton<TService>(Func<TService> instanceCreator);

        TService Resolve<TService>();
    }
}