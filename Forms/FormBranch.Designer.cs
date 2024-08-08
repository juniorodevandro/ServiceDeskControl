namespace Desenvolvimento
{
    partial class FormBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBranch));
            panelTopBranch = new Panel();
            textBoxSDBranch = new TextBox();
            textBoxVersaoBranch = new TextBox();
            buttonMyBranch = new Button();
            buttonReload = new Button();
            treeViewBranch = new TreeView();
            contextMenuStripBranch = new ContextMenuStrip(components);
            showLogToolStripMenuItem = new ToolStripMenuItem();
            panelTopBranch.SuspendLayout();
            contextMenuStripBranch.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopBranch
            // 
            panelTopBranch.Controls.Add(textBoxSDBranch);
            panelTopBranch.Controls.Add(textBoxVersaoBranch);
            panelTopBranch.Controls.Add(buttonMyBranch);
            panelTopBranch.Controls.Add(buttonReload);
            panelTopBranch.Dock = DockStyle.Top;
            panelTopBranch.Location = new Point(3, 0);
            panelTopBranch.Name = "panelTopBranch";
            panelTopBranch.Size = new Size(794, 24);
            panelTopBranch.TabIndex = 4;
            // 
            // textBoxSDBranch
            // 
            textBoxSDBranch.BackColor = SystemColors.ControlLight;
            textBoxSDBranch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSDBranch.Dock = DockStyle.Fill;
            textBoxSDBranch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSDBranch.Location = new Point(39, 0);
            textBoxSDBranch.Name = "textBoxSDBranch";
            textBoxSDBranch.Size = new Size(634, 25);
            textBoxSDBranch.TabIndex = 2;
            textBoxSDBranch.WordWrap = false;
            textBoxSDBranch.TextChanged += textBoxSDBranch_TextChanged;
            // 
            // textBoxVersaoBranch
            // 
            textBoxVersaoBranch.BackColor = SystemColors.ControlLight;
            textBoxVersaoBranch.BorderStyle = BorderStyle.FixedSingle;
            textBoxVersaoBranch.Dock = DockStyle.Right;
            textBoxVersaoBranch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxVersaoBranch.Location = new Point(673, 0);
            textBoxVersaoBranch.Name = "textBoxVersaoBranch";
            textBoxVersaoBranch.Size = new Size(80, 25);
            textBoxVersaoBranch.TabIndex = 3;
            textBoxVersaoBranch.WordWrap = false;
            // 
            // buttonMyBranch
            // 
            buttonMyBranch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonMyBranch.BackColor = SystemColors.ControlLight;
            buttonMyBranch.Dock = DockStyle.Right;
            buttonMyBranch.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 128);
            buttonMyBranch.FlatStyle = FlatStyle.Popup;
            buttonMyBranch.Image = (Image)resources.GetObject("buttonMyBranch.Image");
            buttonMyBranch.Location = new Point(753, 0);
            buttonMyBranch.Name = "buttonMyBranch";
            buttonMyBranch.Size = new Size(41, 24);
            buttonMyBranch.TabIndex = 4;
            buttonMyBranch.UseVisualStyleBackColor = false;
            buttonMyBranch.Click += buttonMyBranch_Click;
            // 
            // buttonReload
            // 
            buttonReload.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonReload.BackColor = SystemColors.ControlLight;
            buttonReload.Dock = DockStyle.Left;
            buttonReload.FlatStyle = FlatStyle.Popup;
            buttonReload.Image = (Image)resources.GetObject("buttonReload.Image");
            buttonReload.Location = new Point(0, 0);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(39, 24);
            buttonReload.TabIndex = 1;
            buttonReload.UseVisualStyleBackColor = false;
            buttonReload.Click += Reload_Click;
            // 
            // treeViewBranch
            // 
            treeViewBranch.BackColor = SystemColors.ControlDark;
            treeViewBranch.ContextMenuStrip = contextMenuStripBranch;
            treeViewBranch.Dock = DockStyle.Fill;
            treeViewBranch.Location = new Point(3, 24);
            treeViewBranch.Name = "treeViewBranch";
            treeViewBranch.Size = new Size(794, 423);
            treeViewBranch.TabIndex = 3;
            // 
            // contextMenuStripBranch
            // 
            contextMenuStripBranch.Items.AddRange(new ToolStripItem[] { showLogToolStripMenuItem });
            contextMenuStripBranch.Name = "contextMenuStripBranch";
            contextMenuStripBranch.Size = new Size(124, 26);
            // 
            // showLogToolStripMenuItem
            // 
            showLogToolStripMenuItem.Name = "showLogToolStripMenuItem";
            showLogToolStripMenuItem.Size = new Size(123, 22);
            showLogToolStripMenuItem.Text = "ShowLog";
            showLogToolStripMenuItem.Click += showLogToolStripMenuItem_Click;
            // 
            // FormBranch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(treeViewBranch);
            Controls.Add(panelTopBranch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBranch";
            Padding = new Padding(3, 0, 3, 3);
            Text = "FormBranch";
            Load += FormBranch_Load;
            panelTopBranch.ResumeLayout(false);
            panelTopBranch.PerformLayout();
            contextMenuStripBranch.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelTopBranch;
        private TreeView treeViewBranch;
        private TextBox textBoxSDBranch;
        private Button buttonReload;
        private TextBox textBoxVersaoBranch;
        private ContextMenuStrip contextMenuStripBranch;
        private ToolStripMenuItem showLogToolStripMenuItem;
        private Button buttonMyBranch;
    }
}