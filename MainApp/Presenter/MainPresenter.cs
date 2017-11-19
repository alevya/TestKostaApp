using System;
using System.Windows.Forms;
using MainApp.Common;
using MainApp.View;

namespace MainApp.Presenter
{
    internal class MainPresenter :BasePresenter<IMainView>
    {
        public MainPresenter(IAppController controller, IMainView view) : base(controller, view)
        {
            View.SelectPage += () => ViewOnSelectedPage(View.SelectedPage);
            
        }

        private void ViewOnSelectedPage(Control control)
        {
            if (control.Name == "tp_employee")
            {
                Controller.Run<EmployeePresenter>();
                //control.Controls.Add();
            }
        }
    }
}
