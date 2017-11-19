using MainApp.Common;
using MainApp.View;

namespace MainApp.Presenter
{
    internal class DepartmentPresenter : BasePresenter<IDepartmentView>
    {
        public DepartmentPresenter(IAppController controller, IDepartmentView view) : base(controller, view)
        {
        }
    }
}
