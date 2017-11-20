using System.Windows.Forms;
using MainApp.Common;
using MainApp.View;

namespace MainApp.Presenter
{
    //internal class EmployeePresenter : BasePresenter<IEmployeeView>
    //{
    //    public EmployeePresenter(IAppController controller, IEmployeeView view) : base(controller, view)
    //    {

    //    }
    //}

    internal class EmployeePresenter : BasePresenter<IEmployeeView, TabPage>
    {
        public EmployeePresenter(IAppController controller, IEmployeeView view) : base(controller, view)
        {

        }

        public override void Run(TabPage argument)
        {
            argument.Controls.Add((Control)View);
        }
    }
}
