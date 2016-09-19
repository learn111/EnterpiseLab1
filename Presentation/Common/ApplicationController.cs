using Presentation.Presenters;
using Presentation.Views;

namespace Presentation.Common
{
    public class ApplicationController : IApplicationController
    {
        private readonly IContainer _container;

        public ApplicationController(IContainer container)
        {
            _container = container;
            _container.RegisterInstance<IApplicationController>(this);
        }

        public IApplicationController RegisterView<TView, TImplementation>() where TView : IView
            where TImplementation : class, TView
        {
            _container.Register<TView, TImplementation>();
            return this;
        }

        public IApplicationController RegisterInstance<TArgument>(TArgument instance)
        {
            _container.RegisterInstance(instance);
            return this;
        }

        public IApplicationController RegisterService<TService, TImplementation>()
            where TImplementation : class, TService
        {
            _container.Register<TService, TImplementation>();
            return this;
        }

        public void Run<TPresenter>() where TPresenter : class, IPresenter
        {
            if (!_container.IsRegistered<TPresenter>())
                _container.Register<TPresenter>();

            var presenter = _container.Resolve<TPresenter>();
            presenter.Run();
        }

        public void Run<TPresenter, TArgumnent>(TArgumnent argumnent) where TPresenter : class, IPresenter<TArgumnent>
        {
            if (!_container.IsRegistered<TPresenter>())
                _container.Register<TPresenter>();

            var presenter = _container.Resolve<TPresenter>();
            presenter.Run(argumnent);
        }
    }
}