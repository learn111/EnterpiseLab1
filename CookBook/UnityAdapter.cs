using Microsoft.Practices.Unity;
using Presentation.Common;

namespace CookBook
{
    internal class UnityAdapter : IContainer
    {
        private readonly UnityContainer _container = new UnityContainer();

        public void Register<TService, TImplementation>() where TImplementation : TService
        {
            _container.RegisterType<TService, TImplementation>();
        }

        public void Register<TService>()
        {
            _container.RegisterType<TService>();
        }

        public void RegisterInstance<T>(T instance)
        {
            _container.RegisterInstance(instance);
        }

        public TService Resolve<TService>()
        {
            return _container.Resolve<TService>();
        }

        public bool IsRegistered<TService>()
        {
            return _container.IsRegistered<TService>();
        }
    }
}