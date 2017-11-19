using MainApp.Common;
using MainApp.View;

namespace MainApp.Presenter
{
    internal class EmployeePresenter : BasePresenter<IEmployeeView>
    {
        public EmployeePresenter(IAppController controller, IEmployeeView view) : base(controller, view)
        {
        }
    }
}
