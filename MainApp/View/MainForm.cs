using System;
using System.Windows.Forms;

namespace MainApp.View
{
    public partial class MainForm : Form, IMainView
    {

        private readonly ApplicationContext _appContext;
        public MainForm(ApplicationContext appContext)
        {
            _appContext = appContext;
            InitializeComponent();
            tc_organization.Selected += (sender, args) => _invoke(SelectPage);
        }

#region IMainView Implements
        public new void Show()
        {
            _appContext.MainForm = this;
            Application.Run(_appContext);
        }

        public event Action SelectPage;
        public void ShowError(string msgError)
        {
            
        }

        public Control SelectedPage
        {
            get => tc_organization.SelectedTab;
        }

#endregion

        private void _invoke(Action action)
        {
            action?.Invoke();
        }
    }
}
