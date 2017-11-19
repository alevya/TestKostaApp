using System;
using System.Windows.Forms;
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


            var viewLoader = new ViewLoader();
            viewLoader.LoadEmployeeView();
            Application.Run(viewLoader.LoadedLastView);
            //Application.Run(new MainForm());
        }
    }
}
