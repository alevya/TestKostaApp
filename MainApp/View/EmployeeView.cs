using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainApp.View
{
    public partial class EmployeeView : UserControl, IEmployeeView
    {
        public EmployeeView()
        {
            InitializeComponent();
            Binding = new BindingSource();
            dgvEmployee.DataSource = Binding;
            
        }

        public BindingSource Binding { get; }
    }
}
