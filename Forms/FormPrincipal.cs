using Desenvolvimento.Forms;

namespace Desenvolvimento
{
    public partial class FormPrincipal : FormBase
    {
        private FormBranch? _formBranch = null;
        private FormFonte? _formFonte = null;
        private FormUserStory? _formUserStory = null;
        private FormConfiguracao? _formConfiguracao = null;
        private FormFormatarSQL? _formFormatarSQL = null;
        private FormDocumentacao? _formDocumentacao = null;

        private bool arrastando = false;
        private Point posicaoInicial;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        [STAThread]
        private static void Thread()
        {
            Application.EnableVisualStyles();
            Application.Run(new FormPrincipal());
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            ButtonFonte_Click(null, null);
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);

            Form? f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        bool sideBarExpand = false;
        private void sidebarTrasition_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.Width <= 50)
                {
                    sideBarExpand = false;
                    sidebarTrasition.Stop();
                    mainpanel.Width += sideBar.Width;
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width >= 225)
                {
                    sideBarExpand = true;
                    sidebarTrasition.Stop();
                    mainpanel.Width += sideBar.Width;
                }
            }
        }

        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            sidebarTrasition.Start();
        }

        private void ButtonFonte_Click(object sender, EventArgs e)
        {
            if (_formFonte == null)
            {
                _formFonte = new FormFonte();
                loadform(_formFonte);
            }
            else
            {
                loadform(_formFonte);
            }
        }

        private void buttonBranch_Click(object sender, EventArgs e)
        {
            if (_formBranch == null)
            {
                _formBranch = new FormBranch();
                loadform(_formBranch);
            }
            else
            {
                loadform(_formBranch);
            }
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                arrastando = true;
                posicaoInicial = e.Location;
            }
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastando)
            {
                this.Left = e.X + this.Left - posicaoInicial.X;
                this.Top = e.Y + this.Top - posicaoInicial.Y;
            }
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            arrastando = false;
        }

        private void Main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            switch (this.WindowState)
            {
                case FormWindowState.Normal:
                    this.WindowState = FormWindowState.Maximized;
                    break;

                case FormWindowState.Maximized:
                    this.WindowState = FormWindowState.Normal;
                    break;
            }
        }

        private void buttonUserStory_Click(object sender, EventArgs e)
        {
            if (_formUserStory == null)
            {
                _formUserStory = new FormUserStory();
                loadform(_formUserStory);
            }
            else
            {
                loadform(_formUserStory);
            }
        }

        private void buttonConfiguracao_Click(object sender, EventArgs e)
        {
            if (_formConfiguracao == null)
            {
                _formConfiguracao = new FormConfiguracao();
                loadform(_formConfiguracao);
            }
            else
            {
                loadform(_formConfiguracao);
            }
        }

        private void buttonFormatarSQL_Click(object sender, EventArgs e)
        {
            if (_formFormatarSQL == null)
            {
                _formFormatarSQL = new FormFormatarSQL();
                loadform(_formFormatarSQL);
            }
            else
            {
                loadform(_formFormatarSQL);
            }
        }

        private void buttonOpcao_MouseClick(object sender, MouseEventArgs e)
        {
            contextMenuStripOpcao.Show(buttonOpcao, e.Location);
        }

        private void reiniciarEscalaServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _utils.StopService("EscalaService");

            _utils.StartService("EscalaService");
        }

        private void iniciarProcessSystem_Click(object sender, EventArgs e)
        {
            _utils.ExecuteCommand("C:\\Escalasoft\\Bin\\EscalaProcessSystem.Exe localhost local /processo:PROCESSOEXECUCAOTAREFASERVIDOR /usuario:system");
        }

        private void reiniciarEscalaWebSerivceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _utils.StopService("EscalaWebService");

            _utils.StartService("EscalaWebService");
        }

        private void buttonDocumentacao_Click(object sender, EventArgs e)
        {
            if (_formDocumentacao == null)
            {
                _formDocumentacao = new FormDocumentacao();
                loadform(_formDocumentacao);
            }
            else
            {
                loadform(_formDocumentacao);
            }
        }
    }

}

    