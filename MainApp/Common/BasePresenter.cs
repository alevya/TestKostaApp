namespace MainApp.Common
{
    internal abstract class BasePresenter<TView> :IPresenter where TView :IView
    {
        protected TView View { get; }
        protected IAppController Controller { get; }

        protected BasePresenter(IAppController controller, TView view)
        {
            Controller = controller;
            View = view;
        }

        public void Run()
        {
            View.Show();
        }

    }

    internal abstract class BasePresenter<TView, TArg> : IPresenter<TArg> where TView : IView
    {
        protected TView View { get; }
        protected IAppController Controller { get; }

        protected BasePresenter(IAppController controller, TView view)
        {
            Controller = controller;
            View = view;
        }

        public abstract void Run(TArg argument);
    }
}
