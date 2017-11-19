using MainApp.Common;
using MainApp.View;

namespace MainApp.Presenter
{
    internal class MainPresenter :BasePresenter<IMainView>
    {
        public MainPresenter(IAppController controller, IMainView view) : base(controller, view)
        {
            
        }
    }
}
