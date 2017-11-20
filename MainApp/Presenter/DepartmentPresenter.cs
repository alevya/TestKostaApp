using System.Windows.Forms;
using MainApp.Common;
using MainApp.Model;
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
        private IDbService _dbService;
        public DepartmentPresenter(IAppController controller, IDepartmentView view, IDbService dbService) : base(controller, view)
        {
            _dbService = dbService;
        }

        public override void Run(TabPage argument)
        {
            argument.Controls.Add((Control)View);
        }
    }
}
