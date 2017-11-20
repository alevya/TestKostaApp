using System.Collections;
using System.Windows.Forms;
using MainApp.Common;
using MainApp.Model;
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
        private readonly IDbService _dbService;

        public EmployeePresenter(IAppController controller, IEmployeeView view, IDbService dbService) : base(controller, view)
        {
            _dbService = dbService;
             AllEmployees =_dbService.LoadEmployee();
            View.Binding.DataSource = AllEmployees;
        }

        public override void Run(TabPage argument)
        {
            argument.Controls.Add((Control)View);
        }

        public IEnumerable AllEmployees
        { get; private set; }
    }
}
