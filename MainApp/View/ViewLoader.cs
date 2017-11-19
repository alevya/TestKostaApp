using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainApp.View
{
    internal class ViewLoader : IViewLoader
    {
        private Form _loadedLastView;
        public void LoadEmployeeView()
        {
            var ev = new EmployeeView();
            _loadedLastView = ev;
        }

        public void LoadDepartmentView()
        {
            var dv = new DepartmentView();
            _loadedLastView = dv;
        }

        public Form LoadedLastView
        {
            get => _loadedLastView;
        }

        private void _loadView(Control view)
        {
            view.Show();
        }
    }
}
