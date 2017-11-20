using System;
using System.Linq.Expressions;

namespace MainApp.Common
{
    internal interface IContainer
    {
        void Register<TService, TImplementation>() where TImplementation : TService;
        void Register<TService>();
        void RegisterInstance<T>(T instance);
        TService Resolve<TService>();
        TService Resolve<TService>(string serviceName);
        bool IsRegistered<TService>();
        void Register<TService, TArgument>(Expression<Func<TArgument, TService>> factory);

    }
}
