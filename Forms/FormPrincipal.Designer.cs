namespace Desenvolvimento
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            nightControlBox = new ReaLTaiizor.Controls.NightControlBox();
            panelTop = new Panel();
            ButtonMenu = new PictureBox();
            sideBar = new FlowLayoutPanel();
            panelSpaceTop = new Panel();
            panelFontes = new Panel();
            ButtonFonte = new Button();
            panelFormatarSQL = new Panel();
            buttonFormatarSQL = new Button();
            panelDocumentacao = new Panel();
            buttonDocumentacao = new Button();
            panelConfiguracao = new Panel();
            buttonConfiguracao = new Button();
            panelBranch = new Panel();
            buttonBranch = new Button();
            panelOpcao = new Panel();
            buttonOpcao = new Button();
            contextMenuStripOpcao = new ContextMenuStrip(components);
            reiniciarEscalaService = new ToolStripMenuItem();
            reiniciarEscalaWebSerivceToolStripMenuItem = new ToolStripMenuItem();
            iniciarProcessSystem = new ToolStripMenuItem();
            panelLimparBanco = new Panel();
            buttonLimparBanco = new Button();
            sidebarTrasition = new System.Windows.Forms.Timer(components);
            mainpanel = new Panel();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ButtonMenu).BeginInit();
            sideBar.SuspendLayout();
            panelFontes.SuspendLayout();
            panelFormatarSQL.SuspendLayout();
            panelDocumentacao.SuspendLayout();
            panelConfiguracao.SuspendLayout();
            panelBranch.SuspendLayout();
            panelOpcao.SuspendLayout();
            contextMenuStripOpcao.SuspendLayout();
            panelLimparBanco.SuspendLayout();
            SuspendLayout();
            // 
            // nightControlBox
            // 
            nightControlBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox.BackColor = Color.WhiteSmoke;
            nightControlBox.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox.CloseHoverForeColor = Color.White;
            nightControlBox.DefaultLocation = true;
            nightControlBox.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox.EnableMaximizeButton = true;
            nightControlBox.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox.EnableMinimizeButton = true;
            nightControlBox.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox.Location = new Point(831, 0);
            nightControlBox.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox.MaximizeHoverForeColor = Color.White;
            nightControlBox.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox.MinimizeHoverForeColor = Color.White;
            nightControlBox.Name = "nightControlBox";
            nightControlBox.Size = new Size(139, 31);
            nightControlBox.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.WhiteSmoke;
            panelTop.Controls.Add(ButtonMenu);
            panelTop.Controls.Add(nightControlBox);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(970, 32);
            panelTop.TabIndex = 1;
            panelTop.MouseDoubleClick += Main_MouseDoubleClick;
            panelTop.MouseDown += Main_MouseDown;
            panelTop.MouseMove += Main_MouseMove;
            panelTop.MouseUp += Main_MouseUp;
            // 
            // ButtonMenu
            // 
            ButtonMenu.Image = (Image)resources.GetObject("ButtonMenu.Image");
            ButtonMenu.Location = new Point(3, 2);
            ButtonMenu.Name = "ButtonMenu";
            ButtonMenu.Size = new Size(38, 29);
            ButtonMenu.SizeMode = PictureBoxSizeMode.CenterImage;
            ButtonMenu.TabIndex = 1;
            ButtonMenu.TabStop = false;
            ButtonMenu.Click += ButtonMenu_Click;
            // 
            // sideBar
            // 
            sideBar.Controls.Add(panelSpaceTop);
            sideBar.Controls.Add(panelFontes);
            sideBar.Controls.Add(panelBranch);
            sideBar.Controls.Add(panelDocumentacao);
            sideBar.Controls.Add(panelFormatarSQL);
            sideBar.Controls.Add(panelLimparBanco);
            sideBar.Controls.Add(panelConfiguracao);
            sideBar.Controls.Add(panelOpcao);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 32);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(50, 565);
            sideBar.TabIndex = 2;
            // 
            // panelSpaceTop
            // 
            panelSpaceTop.Location = new Point(3, 3);
            panelSpaceTop.Name = "panelSpaceTop";
            panelSpaceTop.Size = new Size(222, 10);
            panelSpaceTop.TabIndex = 4;
            // 
            // panelFontes
            // 
            panelFontes.Controls.Add(ButtonFonte);
            panelFontes.Location = new Point(3, 19);
            panelFontes.Name = "panelFontes";
            panelFontes.Size = new Size(222, 47);
            panelFontes.TabIndex = 3;
            // 
            // ButtonFonte
            // 
            ButtonFonte.BackColor = Color.FromArgb(40, 48, 51);
            ButtonFonte.FlatAppearance.BorderSize = 0;
            ButtonFonte.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonFonte.ForeColor = SystemColors.ControlLight;
            ButtonFonte.Image = (Image)resources.GetObject("ButtonFonte.Image");
            ButtonFonte.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonFonte.Location = new Point(-11, -9);
            ButtonFonte.Name = "ButtonFonte";
            ButtonFonte.Padding = new Padding(15, 0, 0, 0);
            ButtonFonte.Size = new Size(252, 67);
            ButtonFonte.TabIndex = 0;
            ButtonFonte.Text = "             Fontes";
            ButtonFonte.TextAlign = ContentAlignment.MiddleLeft;
            ButtonFonte.UseMnemonic = false;
            ButtonFonte.UseVisualStyleBackColor = false;
            ButtonFonte.Click += ButtonFonte_Click;
            // 
            // panelFormatarSQL
            // 
            panelFormatarSQL.Controls.Add(buttonFormatarSQL);
            panelFormatarSQL.Location = new Point(3, 178);
            panelFormatarSQL.Name = "panelFormatarSQL";
            panelFormatarSQL.Size = new Size(222, 47);
            panelFormatarSQL.TabIndex = 13;
            // 
            // buttonFormatarSQL
            // 
            buttonFormatarSQL.BackColor = Color.FromArgb(40, 48, 51);
            buttonFormatarSQL.FlatAppearance.BorderSize = 0;
            buttonFormatarSQL.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFormatarSQL.ForeColor = SystemColors.ControlLight;
            buttonFormatarSQL.Image = (Image)resources.GetObject("buttonFormatarSQL.Image");
            buttonFormatarSQL.ImageAlign = ContentAlignment.MiddleLeft;
            buttonFormatarSQL.Location = new Point(-11, -9);
            buttonFormatarSQL.Name = "buttonFormatarSQL";
            buttonFormatarSQL.Padding = new Padding(15, 0, 0, 0);
            buttonFormatarSQL.Size = new Size(252, 67);
            buttonFormatarSQL.TabIndex = 0;
            buttonFormatarSQL.Text = "             Formatar SQL";
            buttonFormatarSQL.TextAlign = ContentAlignment.MiddleLeft;
            buttonFormatarSQL.UseMnemonic = false;
            buttonFormatarSQL.UseVisualStyleBackColor = false;
            buttonFormatarSQL.Click += buttonFormatarSQL_Click;
            // 
            // panelDocumentacao
            // 
            panelDocumentacao.Controls.Add(buttonDocumentacao);
            panelDocumentacao.Location = new Point(3, 125);
            panelDocumentacao.Name = "panelDocumentacao";
            panelDocumentacao.Size = new Size(222, 47);
            panelDocumentacao.TabIndex = 11;
            // 
            // buttonDocumentacao
            // 
            buttonDocumentacao.BackColor = Color.FromArgb(40, 48, 51);
            buttonDocumentacao.FlatAppearance.BorderSize = 0;
            buttonDocumentacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDocumentacao.ForeColor = SystemColors.ControlLight;
            buttonDocumentacao.Image = (Image)resources.GetObject("buttonDocumentacao.Image");
            buttonDocumentacao.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDocumentacao.Location = new Point(-11, -9);
            buttonDocumentacao.Name = "buttonDocumentacao";
            buttonDocumentacao.Padding = new Padding(15, 0, 0, 0);
            buttonDocumentacao.Size = new Size(252, 67);
            buttonDocumentacao.TabIndex = 0;
            buttonDocumentacao.Text = "             Docs";
            buttonDocumentacao.TextAlign = ContentAlignment.MiddleLeft;
            buttonDocumentacao.UseMnemonic = false;
            buttonDocumentacao.UseVisualStyleBackColor = false;
            buttonDocumentacao.Click += buttonUserStory_Click;
            // 
            // panelConfiguracao
            // 
            panelConfiguracao.Controls.Add(buttonConfiguracao);
            panelConfiguracao.Location = new Point(3, 284);
            panelConfiguracao.Name = "panelConfiguracao";
            panelConfiguracao.Size = new Size(222, 47);
            panelConfiguracao.TabIndex = 12;
            // 
            // buttonConfiguracao
            // 
            buttonConfiguracao.BackColor = Color.FromArgb(40, 48, 51);
            buttonConfiguracao.FlatAppearance.BorderSize = 0;
            buttonConfiguracao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonConfiguracao.ForeColor = SystemColors.ControlLight;
            buttonConfiguracao.Image = (Image)resources.GetObject("buttonConfiguracao.Image");
            buttonConfiguracao.ImageAlign = ContentAlignment.MiddleLeft;
            buttonConfiguracao.Location = new Point(-11, -9);
            buttonConfiguracao.Name = "buttonConfiguracao";
            buttonConfiguracao.Padding = new Padding(15, 0, 0, 0);
            buttonConfiguracao.Size = new Size(252, 67);
            buttonConfiguracao.TabIndex = 0;
            buttonConfiguracao.Text = "             Configuração";
            buttonConfiguracao.TextAlign = ContentAlignment.MiddleLeft;
            buttonConfiguracao.UseMnemonic = false;
            buttonConfiguracao.UseVisualStyleBackColor = false;
            buttonConfiguracao.Click += buttonConfiguracao_Click;
            // 
            // panelBranch
            // 
            panelBranch.Controls.Add(buttonBranch);
            panelBranch.Location = new Point(3, 72);
            panelBranch.Name = "panelBranch";
            panelBranch.Size = new Size(222, 47);
            panelBranch.TabIndex = 4;
            // 
            // buttonBranch
            // 
            buttonBranch.BackColor = Color.FromArgb(40, 48, 51);
            buttonBranch.FlatAppearance.BorderSize = 0;
            buttonBranch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBranch.ForeColor = SystemColors.ControlLight;
            buttonBranch.Image = (Image)resources.GetObject("buttonBranch.Image");
            buttonBranch.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBranch.Location = new Point(-11, -9);
            buttonBranch.Name = "buttonBranch";
            buttonBranch.Padding = new Padding(15, 0, 0, 0);
            buttonBranch.Size = new Size(252, 67);
            buttonBranch.TabIndex = 0;
            buttonBranch.Text = "             Branch";
            buttonBranch.TextAlign = ContentAlignment.MiddleLeft;
            buttonBranch.UseMnemonic = false;
            buttonBranch.UseVisualStyleBackColor = false;
            buttonBranch.Click += buttonBranch_Click;
            // 
            // panelOpcao
            // 
            panelOpcao.Controls.Add(buttonOpcao);
            panelOpcao.Location = new Point(3, 337);
            panelOpcao.Name = "panelOpcao";
            panelOpcao.Size = new Size(222, 47);
            panelOpcao.TabIndex = 14;
            // 
            // buttonOpcao
            // 
            buttonOpcao.BackColor = Color.FromArgb(40, 48, 51);
            buttonOpcao.ContextMenuStrip = contextMenuStripOpcao;
            buttonOpcao.FlatAppearance.BorderSize = 0;
            buttonOpcao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOpcao.ForeColor = SystemColors.ControlLight;
            buttonOpcao.Image = (Image)resources.GetObject("buttonOpcao.Image");
            buttonOpcao.ImageAlign = ContentAlignment.MiddleLeft;
            buttonOpcao.Location = new Point(-11, -9);
            buttonOpcao.Name = "buttonOpcao";
            buttonOpcao.Padding = new Padding(15, 0, 0, 0);
            buttonOpcao.Size = new Size(252, 67);
            buttonOpcao.TabIndex = 0;
            buttonOpcao.Text = "             Opções";
            buttonOpcao.TextAlign = ContentAlignment.MiddleLeft;
            buttonOpcao.UseMnemonic = false;
            buttonOpcao.UseVisualStyleBackColor = false;
            buttonOpcao.MouseClick += buttonOpcao_MouseClick;
            // 
            // contextMenuStripOpcao
            // 
            contextMenuStripOpcao.Items.AddRange(new ToolStripItem[] { reiniciarEscalaService, reiniciarEscalaWebSerivceToolStripMenuItem, iniciarProcessSystem });
            contextMenuStripOpcao.Name = "contextMenuStripOpcao";
            contextMenuStripOpcao.Size = new Size(216, 70);
            // 
            // reiniciarEscalaService
            // 
            reiniciarEscalaService.Name = "reiniciarEscalaService";
            reiniciarEscalaService.Size = new Size(215, 22);
            reiniciarEscalaService.Text = "Reiniciar EscalaService";
            reiniciarEscalaService.Click += reiniciarEscalaServiceToolStripMenuItem_Click;
            // 
            // reiniciarEscalaWebSerivceToolStripMenuItem
            // 
            reiniciarEscalaWebSerivceToolStripMenuItem.Name = "reiniciarEscalaWebSerivceToolStripMenuItem";
            reiniciarEscalaWebSerivceToolStripMenuItem.Size = new Size(215, 22);
            reiniciarEscalaWebSerivceToolStripMenuItem.Text = "Reiniciar EscalaWebSerivce";
            reiniciarEscalaWebSerivceToolStripMenuItem.Click += reiniciarEscalaWebSerivceToolStripMenuItem_Click;
            // 
            // iniciarProcessSystem
            // 
            iniciarProcessSystem.Name = "iniciarProcessSystem";
            iniciarProcessSystem.Size = new Size(215, 22);
            iniciarProcessSystem.Text = "Iniciar ProcessSystem";
            iniciarProcessSystem.Click += iniciarProcessSystem_Click;
            // 
            // panelLimparBanco
            // 
            panelLimparBanco.Controls.Add(buttonLimparBanco);
            panelLimparBanco.Location = new Point(3, 231);
            panelLimparBanco.Name = "panelLimparBanco";
            panelLimparBanco.Size = new Size(222, 47);
            panelLimparBanco.TabIndex = 15;
            // 
            // buttonLimparBanco
            // 
            buttonLimparBanco.BackColor = Color.FromArgb(40, 48, 51);
            buttonLimparBanco.FlatAppearance.BorderSize = 0;
            buttonLimparBanco.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimparBanco.ForeColor = SystemColors.ControlLight;
            buttonLimparBanco.Image = (Image)resources.GetObject("buttonLimparBanco.Image");
            buttonLimparBanco.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLimparBanco.Location = new Point(-11, -9);
            buttonLimparBanco.Name = "buttonLimparBanco";
            buttonLimparBanco.Padding = new Padding(15, 0, 0, 0);
            buttonLimparBanco.Size = new Size(252, 67);
            buttonLimparBanco.TabIndex = 0;
            buttonLimparBanco.Text = "             Limpar banco";
            buttonLimparBanco.TextAlign = ContentAlignment.MiddleLeft;
            buttonLimparBanco.UseMnemonic = false;
            buttonLimparBanco.UseVisualStyleBackColor = false;
            buttonLimparBanco.Click += buttonLimparBanco_Click;
            // 
            // sidebarTrasition
            // 
            sidebarTrasition.Interval = 10;
            sidebarTrasition.Tick += sidebarTrasition_Tick;
            // 
            // mainpanel
            // 
            mainpanel.BackColor = Color.DarkGray;
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(50, 32);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(920, 565);
            mainpanel.TabIndex = 4;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(40, 48, 51);
            ClientSize = new Size(970, 597);
            Controls.Add(mainpanel);
            Controls.Add(sideBar);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1032);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Desenvolvimento";
            Load += FormPrincipal_Load;
            MouseDown += Main_MouseDown;
            MouseMove += Main_MouseMove;
            MouseUp += Main_MouseUp;
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ButtonMenu).EndInit();
            sideBar.ResumeLayout(false);
            panelFontes.ResumeLayout(false);
            panelFormatarSQL.ResumeLayout(false);
            panelDocumentacao.ResumeLayout(false);
            panelConfiguracao.ResumeLayout(false);
            panelBranch.ResumeLayout(false);
            panelOpcao.ResumeLayout(false);
            contextMenuStripOpcao.ResumeLayout(false);
            panelLimparBanco.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.NightControlBox nightControlBox;
        private Panel panelTop;
        private PictureBox ButtonMenu;
        private FlowLayoutPanel sideBar;
        private System.Windows.Forms.Timer sidebarTrasition;
        private Panel panelSpaceTop;
        private Panel mainpanel;
        private ContextMenuStrip contextMenuStripOpcao;
        private ToolStripMenuItem reiniciarEscalaService;
        private ToolStripMenuItem reiniciarEscalaWebSerivceToolStripMenuItem;
        private ToolStripMenuItem iniciarProcessSystem;
        private Panel panelFontes;
        private Button ButtonFonte;
        private Panel panelOpcao;
        private Button buttonOpcao;
        private Panel panelConfiguracao;
        private Button buttonConfiguracao;
        private Panel panelFormatarSQL;
        private Button buttonFormatarSQL;
        private Panel panelDocumentacao;
        private Button buttonDocumentacao;
        private Panel panelBranch;
        private Button buttonBranch;
        private Panel panelLimparBanco;
        private Button buttonLimparBanco;
    }
}
