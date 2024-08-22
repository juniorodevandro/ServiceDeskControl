namespace Desenvolvimento.Forms
{
    partial class FormLimparBanco
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLimparBanco));
            contextMenuStripBranch = new ContextMenuStrip(components);
            showLogToolStripMenuItem = new ToolStripMenuItem();
            repoBrowserToolStripMenuItem = new ToolStripMenuItem();
            panelTopBranch = new Panel();
            textBoxConexao = new TextBox();
            buttonExecutar = new Button();
            buttonRollback = new Button();
            buttonCommit = new Button();
            buttonTransacao = new Button();
            buttonConectar = new Button();
            textBoxCondicao = new TextBox();
            textBoxTabela = new TextBox();
            textBoxOutPut = new TextBox();
            textBoxTabelaRemovida = new TextBox();
            contextMenuStripBranch.SuspendLayout();
            panelTopBranch.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStripBranch
            // 
            contextMenuStripBranch.Items.AddRange(new ToolStripItem[] { showLogToolStripMenuItem, repoBrowserToolStripMenuItem });
            contextMenuStripBranch.Name = "contextMenuStripBranch";
            contextMenuStripBranch.Size = new Size(144, 48);
            // 
            // showLogToolStripMenuItem
            // 
            showLogToolStripMenuItem.Name = "showLogToolStripMenuItem";
            showLogToolStripMenuItem.Size = new Size(143, 22);
            showLogToolStripMenuItem.Text = "ShowLog";
            // 
            // repoBrowserToolStripMenuItem
            // 
            repoBrowserToolStripMenuItem.Name = "repoBrowserToolStripMenuItem";
            repoBrowserToolStripMenuItem.Size = new Size(143, 22);
            repoBrowserToolStripMenuItem.Text = "RepoBrowser";
            // 
            // panelTopBranch
            // 
            panelTopBranch.Controls.Add(textBoxConexao);
            panelTopBranch.Controls.Add(buttonExecutar);
            panelTopBranch.Controls.Add(buttonRollback);
            panelTopBranch.Controls.Add(buttonCommit);
            panelTopBranch.Controls.Add(buttonTransacao);
            panelTopBranch.Controls.Add(buttonConectar);
            panelTopBranch.Dock = DockStyle.Top;
            panelTopBranch.Location = new Point(3, 0);
            panelTopBranch.Name = "panelTopBranch";
            panelTopBranch.Size = new Size(914, 31);
            panelTopBranch.TabIndex = 6;
            // 
            // textBoxConexao
            // 
            textBoxConexao.BackColor = SystemColors.ControlLight;
            textBoxConexao.BorderStyle = BorderStyle.FixedSingle;
            textBoxConexao.Dock = DockStyle.Fill;
            textBoxConexao.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxConexao.ForeColor = Color.Red;
            textBoxConexao.Location = new Point(500, 0);
            textBoxConexao.Name = "textBoxConexao";
            textBoxConexao.ReadOnly = true;
            textBoxConexao.Size = new Size(414, 31);
            textBoxConexao.TabIndex = 10;
            textBoxConexao.TabStop = false;
            textBoxConexao.Text = "Desconectado";
            textBoxConexao.WordWrap = false;
            // 
            // buttonExecutar
            // 
            buttonExecutar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonExecutar.BackColor = SystemColors.ControlLight;
            buttonExecutar.Dock = DockStyle.Left;
            buttonExecutar.Enabled = false;
            buttonExecutar.FlatStyle = FlatStyle.Popup;
            buttonExecutar.Image = (Image)resources.GetObject("buttonExecutar.Image");
            buttonExecutar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExecutar.Location = new Point(406, 0);
            buttonExecutar.Name = "buttonExecutar";
            buttonExecutar.Size = new Size(94, 31);
            buttonExecutar.TabIndex = 5;
            buttonExecutar.Text = "      Executar";
            buttonExecutar.UseVisualStyleBackColor = false;
            buttonExecutar.Click += buttonExecutar_Click;
            // 
            // buttonRollback
            // 
            buttonRollback.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonRollback.BackColor = SystemColors.ControlLight;
            buttonRollback.Dock = DockStyle.Left;
            buttonRollback.Enabled = false;
            buttonRollback.FlatStyle = FlatStyle.Popup;
            buttonRollback.Image = (Image)resources.GetObject("buttonRollback.Image");
            buttonRollback.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRollback.Location = new Point(312, 0);
            buttonRollback.Name = "buttonRollback";
            buttonRollback.Size = new Size(94, 31);
            buttonRollback.TabIndex = 4;
            buttonRollback.Text = "      Rollback";
            buttonRollback.UseVisualStyleBackColor = false;
            buttonRollback.Click += buttonRollback_Click;
            // 
            // buttonCommit
            // 
            buttonCommit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonCommit.BackColor = SystemColors.ControlLight;
            buttonCommit.Dock = DockStyle.Left;
            buttonCommit.Enabled = false;
            buttonCommit.FlatStyle = FlatStyle.Popup;
            buttonCommit.Image = (Image)resources.GetObject("buttonCommit.Image");
            buttonCommit.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCommit.Location = new Point(218, 0);
            buttonCommit.Name = "buttonCommit";
            buttonCommit.Size = new Size(94, 31);
            buttonCommit.TabIndex = 3;
            buttonCommit.Text = "      Commit";
            buttonCommit.UseVisualStyleBackColor = false;
            buttonCommit.Click += buttonCommit_Click;
            // 
            // buttonTransacao
            // 
            buttonTransacao.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonTransacao.BackColor = SystemColors.ControlLight;
            buttonTransacao.Dock = DockStyle.Left;
            buttonTransacao.Enabled = false;
            buttonTransacao.FlatStyle = FlatStyle.Popup;
            buttonTransacao.Image = (Image)resources.GetObject("buttonTransacao.Image");
            buttonTransacao.ImageAlign = ContentAlignment.MiddleLeft;
            buttonTransacao.Location = new Point(124, 0);
            buttonTransacao.Name = "buttonTransacao";
            buttonTransacao.Size = new Size(94, 31);
            buttonTransacao.TabIndex = 2;
            buttonTransacao.Text = "      Transação";
            buttonTransacao.UseVisualStyleBackColor = false;
            buttonTransacao.Click += buttonTransacao_Click;
            // 
            // buttonConectar
            // 
            buttonConectar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonConectar.BackColor = SystemColors.ControlLight;
            buttonConectar.Dock = DockStyle.Left;
            buttonConectar.FlatStyle = FlatStyle.Popup;
            buttonConectar.Image = (Image)resources.GetObject("buttonConectar.Image");
            buttonConectar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonConectar.Location = new Point(0, 0);
            buttonConectar.Name = "buttonConectar";
            buttonConectar.Size = new Size(124, 31);
            buttonConectar.TabIndex = 1;
            buttonConectar.Text = "      Conectar";
            buttonConectar.UseVisualStyleBackColor = false;
            buttonConectar.Click += buttonConectar_Click;
            // 
            // textBoxCondicao
            // 
            textBoxCondicao.BackColor = SystemColors.ControlLight;
            textBoxCondicao.BorderStyle = BorderStyle.FixedSingle;
            textBoxCondicao.Dock = DockStyle.Top;
            textBoxCondicao.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCondicao.Location = new Point(3, 62);
            textBoxCondicao.Multiline = true;
            textBoxCondicao.Name = "textBoxCondicao";
            textBoxCondicao.Size = new Size(914, 135);
            textBoxCondicao.TabIndex = 7;
            textBoxCondicao.WordWrap = false;
            // 
            // textBoxTabela
            // 
            textBoxTabela.BackColor = SystemColors.ControlLight;
            textBoxTabela.BorderStyle = BorderStyle.FixedSingle;
            textBoxTabela.Dock = DockStyle.Top;
            textBoxTabela.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTabela.Location = new Point(3, 31);
            textBoxTabela.Multiline = true;
            textBoxTabela.Name = "textBoxTabela";
            textBoxTabela.Size = new Size(914, 31);
            textBoxTabela.TabIndex = 6;
            textBoxTabela.WordWrap = false;
            // 
            // textBoxOutPut
            // 
            textBoxOutPut.BackColor = SystemColors.ControlLight;
            textBoxOutPut.BorderStyle = BorderStyle.FixedSingle;
            textBoxOutPut.Dock = DockStyle.Left;
            textBoxOutPut.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxOutPut.Location = new Point(3, 197);
            textBoxOutPut.Multiline = true;
            textBoxOutPut.Name = "textBoxOutPut";
            textBoxOutPut.Size = new Size(456, 365);
            textBoxOutPut.TabIndex = 8;
            textBoxOutPut.WordWrap = false;
            // 
            // textBoxTabelaRemovida
            // 
            textBoxTabelaRemovida.BackColor = SystemColors.ControlLight;
            textBoxTabelaRemovida.BorderStyle = BorderStyle.FixedSingle;
            textBoxTabelaRemovida.Dock = DockStyle.Fill;
            textBoxTabelaRemovida.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTabelaRemovida.Location = new Point(459, 197);
            textBoxTabelaRemovida.Multiline = true;
            textBoxTabelaRemovida.Name = "textBoxTabelaRemovida";
            textBoxTabelaRemovida.Size = new Size(458, 365);
            textBoxTabelaRemovida.TabIndex = 9;
            textBoxTabelaRemovida.WordWrap = false;
            // 
            // FormLimparBanco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(920, 565);
            Controls.Add(textBoxTabelaRemovida);
            Controls.Add(textBoxOutPut);
            Controls.Add(textBoxCondicao);
            Controls.Add(textBoxTabela);
            Controls.Add(panelTopBranch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLimparBanco";
            Padding = new Padding(3, 0, 3, 3);
            Text = "FormLimparBanco";
            contextMenuStripBranch.ResumeLayout(false);
            panelTopBranch.ResumeLayout(false);
            panelTopBranch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStripBranch;
        private ToolStripMenuItem showLogToolStripMenuItem;
        private ToolStripMenuItem repoBrowserToolStripMenuItem;
        private Panel panelTopBranch;
        private Button buttonConectar;
        private Button buttonExecutar;
        private Button buttonRollback;
        private Button buttonTransacao;
        private TextBox textBoxCondicao;
        private TextBox textBoxTabela;
        private TextBox textBoxConexao;
        private Button buttonCommit;
        private TextBox textBoxOutPut;
        private TextBox textBoxTabelaRemovida;
    }
}