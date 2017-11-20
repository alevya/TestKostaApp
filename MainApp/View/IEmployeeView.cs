using System.Windows.Forms;
using MainApp.Common;

namespace MainApp.View
{
    internal interface IEmployeeView :IView
    {
        BindingSource Binding { get; }
    }
}
