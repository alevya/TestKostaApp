﻿namespace MainApp.Common
{
    internal class AppController : IAppController
    {
        private readonly IContainer _container;

        public AppController(IContainer container)
        {
            _container = container;
            _container.RegisterInstance<IAppController>(this);
        }

        public IAppController RegisterView<TView, TImplementation>()
            where TImplementation : class, TView
            where TView : IView
        {
            _container.Register<TView, TImplementation>();
            return this;
        }

        public IAppController RegisterInstance<TInstance>(TInstance instance)
        {
            _container.RegisterInstance(instance);
            return this;
        }

        public IAppController RegisterService<TModel, TImplementation>()
            where TImplementation : class, TModel
        {
            _container.Register<TModel, TImplementation>();
            return this;
        }

        public void Run<TPresenter>() where TPresenter : class, IPresenter
        {
            if (!_container.IsRegistered<TPresenter>())
                _container.Register<TPresenter>();

            var presenter = _container.Resolve<TPresenter>();
            presenter.Run();
        }

        public void Run<TPresenter, TArgument>(TArgument argumnent) where TPresenter : class, IPresenter<TArgument>
        {
            if (!_container.IsRegistered<TPresenter>())
                _container.Register<TPresenter>();

            var presenter = _container.Resolve<TPresenter>();
            presenter.Run(argumnent);
        }

        public IView GetView<TView>(string serviceName) where TView : class, IView
        {
            if (!_container.IsRegistered<TView>())
                return null;
            return _container.Resolve<IView>(serviceName);
        }

    }
}
