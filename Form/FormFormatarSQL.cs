namespace Desenvolvimento
{
    public partial class FormFormatarSQL : Form
    {
        public FormFormatarSQL()
        {
            InitializeComponent();
        }

        [STAThread]
        private static void Thread()
        {
            Application.EnableVisualStyles();
            Application.Run(new FormFormatarSQL());
        }
    }
}
