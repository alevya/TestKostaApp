using System.Windows.Forms;
using MainApp.Common;
using MainApp.View;

namespace MainApp.Presenter
{
    //internal class DepartmentPresenter : BasePresenter<IDepartmentView>
    //{
    //    public DepartmentPresenter(IAppController controller, IDepartmentView view) : base(controller, view)
    //    {
    //    }
    //}

    internal class DepartmentPresenter : BasePresenter<IDepartmentView, TabPage>
    {
        public DepartmentPresenter(IAppController controller, IDepartmentView view) : base(controller, view)
        {
        }

        public override void Run(TabPage argument)
        {
            argument.Controls.Add((Control)View);
        }
    }
}
