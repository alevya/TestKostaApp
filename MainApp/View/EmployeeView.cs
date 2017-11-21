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

            dgvEmployee.AutoGenerateColumns = false;
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.Columns.AddRange(new[]
            {
                new DataGridViewTextBoxColumn{HeaderText = "Имя", DataPropertyName = "FirstName"},
                new DataGridViewTextBoxColumn{HeaderText = "Фамилия", DataPropertyName = "SurName"},
                new DataGridViewTextBoxColumn{HeaderText = "Отчество", DataPropertyName = "Patronymic"},
                new DataGridViewTextBoxColumn{HeaderText = "Должность", DataPropertyName = "Position"},
            });
            dgvEmployee.DataSource = Binding;
        }

        public BindingSource Binding { get; }
    }
}
