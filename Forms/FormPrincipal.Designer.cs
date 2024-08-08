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
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            panelTop = new Panel();
            ButtonMenu = new PictureBox();
            sideBar = new FlowLayoutPanel();
            panel1 = new Panel();
            panelFontes = new Panel();
            ButtonFonte = new Button();
            panelBranch = new Panel();
            buttonBranch = new Button();
            panelDocumentacao = new Panel();
            buttonDocumentacao = new Button();
            panelFormatarSQL = new Panel();
            buttonFormatarSQL = new Button();
            panelConfiguracao = new Panel();
            buttonConfiguracao = new Button();
            sidebarTrasition = new System.Windows.Forms.Timer(components);
            mainpanel = new Panel();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ButtonMenu).BeginInit();
            sideBar.SuspendLayout();
            panelFontes.SuspendLayout();
            panelBranch.SuspendLayout();
            panelDocumentacao.SuspendLayout();
            panelFormatarSQL.SuspendLayout();
            panelConfiguracao.SuspendLayout();
            SuspendLayout();
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.WhiteSmoke;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(831, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.WhiteSmoke;
            panelTop.Controls.Add(ButtonMenu);
            panelTop.Controls.Add(nightControlBox1);
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
            sideBar.Controls.Add(panel1);
            sideBar.Controls.Add(panelFontes);
            sideBar.Controls.Add(panelBranch);
            sideBar.Controls.Add(panelDocumentacao);
            sideBar.Controls.Add(panelFormatarSQL);
            sideBar.Controls.Add(panelConfiguracao);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 32);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(50, 565);
            sideBar.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 10);
            panel1.TabIndex = 4;
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
            // panelDocumentacao
            // 
            panelDocumentacao.Controls.Add(buttonDocumentacao);
            panelDocumentacao.Location = new Point(3, 125);
            panelDocumentacao.Name = "panelDocumentacao";
            panelDocumentacao.Size = new Size(222, 47);
            panelDocumentacao.TabIndex = 4;
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
            buttonDocumentacao.Text = "             Documentação";
            buttonDocumentacao.TextAlign = ContentAlignment.MiddleLeft;
            buttonDocumentacao.UseMnemonic = false;
            buttonDocumentacao.UseVisualStyleBackColor = false;
            buttonDocumentacao.Click += buttonDocumentacao_Click;
            // 
            // panelFormatarSQL
            // 
            panelFormatarSQL.Controls.Add(buttonFormatarSQL);
            panelFormatarSQL.Location = new Point(3, 178);
            panelFormatarSQL.Name = "panelFormatarSQL";
            panelFormatarSQL.Size = new Size(222, 47);
            panelFormatarSQL.TabIndex = 6;
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
            // panelConfiguracao
            // 
            panelConfiguracao.Controls.Add(buttonConfiguracao);
            panelConfiguracao.Location = new Point(3, 231);
            panelConfiguracao.Name = "panelConfiguracao";
            panelConfiguracao.Size = new Size(222, 47);
            panelConfiguracao.TabIndex = 5;
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
            panelBranch.ResumeLayout(false);
            panelDocumentacao.ResumeLayout(false);
            panelFormatarSQL.ResumeLayout(false);
            panelConfiguracao.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Panel panelTop;
        private PictureBox ButtonMenu;
        private FlowLayoutPanel sideBar;
        private Panel panelFontes;
        private Button ButtonFonte;
        private Panel panelBranch;
        private Button buttonBranch;
        private Panel panelDocumentacao;
        private Button buttonDocumentacao;
        private System.Windows.Forms.Timer sidebarTrasition;
        private Panel panel1;
        private Panel mainpanel;
        private Panel panelConfiguracao;
        private Button buttonConfiguracao;
        private Panel panelFormatarSQL;
        private Button buttonFormatarSQL;
    }
}
