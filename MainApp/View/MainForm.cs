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
        }

        public new void Show()
        {
            _appContext.MainForm = this;
            Application.Run(_appContext);
        }
    }
}
