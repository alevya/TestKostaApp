using System;
using System.Windows.Forms;
using MainApp.Common;
using MainApp.Model;
using MainApp.Presenter;
using MainApp.View;

namespace MainApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var controller = new AppController(new LightInjectAdapter());
            controller.RegisterView<IMainView, MainForm>()
                .RegisterView<IEmployeeView, EmployeeView>()
                .RegisterView<IDepartmentView, DepartmentView>()
                //.RegisterService<IDbService, DbService>()
                .RegisterService<IDbService, EntityDbService>()
                .RegisterInstance(new ApplicationContext());

            controller.Run<MainPresenter>();

        }
    }
}
