using System.Windows.Forms;
using MainApp.Common;
using MainApp.View;

namespace MainApp.Presenter
{
    internal class MainPresenter :BasePresenter<IMainView>
    {
        public MainPresenter(IAppController controller, IMainView view) : base(controller, view)
        {
            TabPage tpEmployees = new TabPage("Сотрудники");
            controller.Run<EmployeePresenter, TabPage>(tpEmployees);

            TabPage tpDepartments = new TabPage("Отделы");
            controller.Run<DepartmentPresenter, TabPage>(tpDepartments);

            view.MainTab.TabPages.Add(tpEmployees);
            view.MainTab.TabPages.Add(tpDepartments);
        }
    }
}
