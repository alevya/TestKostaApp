using System.Windows.Forms;

namespace MainApp.Common
{
    public interface IView
    {
        void Show();
        DockStyle Dock { get; set; }
        BindingSource Binding { get; } 
        //void Close();
    }
}
