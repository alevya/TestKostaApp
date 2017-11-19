using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.View
{
    public interface IViewLoader
    {
        void LoadEmployeeView();
        void LoadDepartmentView();
    }
}
