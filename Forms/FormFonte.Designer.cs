namespace Desenvolvimento
{
    partial class FormFonte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFonte));
            contextMenuStripFonte = new ContextMenuStrip(components);
            updateToolStripMenuItem = new ToolStripMenuItem();
            commitToolStripMenuItem = new ToolStripMenuItem();
            showLogToolStripMenuItem = new ToolStripMenuItem();
            switchToolStripMenuItem = new ToolStripMenuItem();
            mergeToolStripMenuItem = new ToolStripMenuItem();
            newBranchToolStripMenuItem = new ToolStripMenuItem();
            openFolderToolStripMenuItem = new ToolStripMenuItem();
            treeViewFonte = new TreeView();
            panelTopFonte = new Panel();
            textBoxSDFonte = new TextBox();
            textBoxVersaoFonte = new TextBox();
            buttonReload = new Button();
            textBoxOutputFonte = new TextBox();
            contextMenuStripFonte.SuspendLayout();
            panelTopFonte.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStripFonte
            // 
            contextMenuStripFonte.Items.AddRange(new ToolStripItem[] { updateToolStripMenuItem, commitToolStripMenuItem, showLogToolStripMenuItem, switchToolStripMenuItem, mergeToolStripMenuItem, newBranchToolStripMenuItem, openFolderToolStripMenuItem });
            contextMenuStripFonte.Name = "contextMenuStripFonte";
            contextMenuStripFonte.Size = new Size(137, 158);
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(136, 22);
            updateToolStripMenuItem.Text = "Update";
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
            // 
            // commitToolStripMenuItem
            // 
            commitToolStripMenuItem.Name = "commitToolStripMenuItem";
            commitToolStripMenuItem.Size = new Size(136, 22);
            commitToolStripMenuItem.Text = "Commit";
            commitToolStripMenuItem.Click += commitToolStripMenuItem_Click;
            // 
            // showLogToolStripMenuItem
            // 
            showLogToolStripMenuItem.Name = "showLogToolStripMenuItem";
            showLogToolStripMenuItem.Size = new Size(136, 22);
            showLogToolStripMenuItem.Text = "ShowLog";
            showLogToolStripMenuItem.Click += showLogToolStripMenuItem_Click;
            // 
            // switchToolStripMenuItem
            // 
            switchToolStripMenuItem.Name = "switchToolStripMenuItem";
            switchToolStripMenuItem.Size = new Size(136, 22);
            switchToolStripMenuItem.Text = "Switch";
            switchToolStripMenuItem.Click += switchToolStripMenuItem_Click;
            // 
            // mergeToolStripMenuItem
            // 
            mergeToolStripMenuItem.Name = "mergeToolStripMenuItem";
            mergeToolStripMenuItem.Size = new Size(136, 22);
            mergeToolStripMenuItem.Text = "Merge";
            mergeToolStripMenuItem.Click += mergeToolStripMenuItem_Click;
            // 
            // newBranchToolStripMenuItem
            // 
            newBranchToolStripMenuItem.Name = "newBranchToolStripMenuItem";
            newBranchToolStripMenuItem.Size = new Size(136, 22);
            newBranchToolStripMenuItem.Text = "NewBranch";
            newBranchToolStripMenuItem.Click += newBranchToolStripMenuItem_Click;
            // 
            // openFolderToolStripMenuItem
            // 
            openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            openFolderToolStripMenuItem.Size = new Size(136, 22);
            openFolderToolStripMenuItem.Text = "OpenFolder";
            openFolderToolStripMenuItem.Click += openFolderToolStripMenuItem_Click;
            // 
            // treeViewFonte
            // 
            treeViewFonte.BackColor = SystemColors.ControlDark;
            treeViewFonte.ContextMenuStrip = contextMenuStripFonte;
            treeViewFonte.Dock = DockStyle.Fill;
            treeViewFonte.Location = new Point(3, 24);
            treeViewFonte.Name = "treeViewFonte";
            treeViewFonte.Size = new Size(794, 423);
            treeViewFonte.TabIndex = 5;
            // 
            // panelTopFonte
            // 
            panelTopFonte.Controls.Add(textBoxSDFonte);
            panelTopFonte.Controls.Add(textBoxVersaoFonte);
            panelTopFonte.Controls.Add(buttonReload);
            panelTopFonte.Dock = DockStyle.Top;
            panelTopFonte.Location = new Point(3, 0);
            panelTopFonte.Name = "panelTopFonte";
            panelTopFonte.Size = new Size(794, 24);
            panelTopFonte.TabIndex = 6;
            // 
            // textBoxSDFonte
            // 
            textBoxSDFonte.BackColor = SystemColors.ControlLight;
            textBoxSDFonte.BorderStyle = BorderStyle.FixedSingle;
            textBoxSDFonte.Dock = DockStyle.Fill;
            textBoxSDFonte.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSDFonte.Location = new Point(39, 0);
            textBoxSDFonte.Name = "textBoxSDFonte";
            textBoxSDFonte.Size = new Size(675, 25);
            textBoxSDFonte.TabIndex = 2;
            textBoxSDFonte.WordWrap = false;
            // 
            // textBoxVersaoFonte
            // 
            textBoxVersaoFonte.BackColor = SystemColors.ControlLight;
            textBoxVersaoFonte.BorderStyle = BorderStyle.FixedSingle;
            textBoxVersaoFonte.Dock = DockStyle.Right;
            textBoxVersaoFonte.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxVersaoFonte.Location = new Point(714, 0);
            textBoxVersaoFonte.Name = "textBoxVersaoFonte";
            textBoxVersaoFonte.Size = new Size(80, 25);
            textBoxVersaoFonte.TabIndex = 3;
            textBoxVersaoFonte.WordWrap = false;
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
            buttonReload.Click += buttonReload_Click;
            // 
            // textBoxOutputFonte
            // 
            textBoxOutputFonte.BackColor = SystemColors.ControlDark;
            textBoxOutputFonte.BorderStyle = BorderStyle.FixedSingle;
            textBoxOutputFonte.Dock = DockStyle.Right;
            textBoxOutputFonte.Location = new Point(290, 24);
            textBoxOutputFonte.Multiline = true;
            textBoxOutputFonte.Name = "textBoxOutputFonte";
            textBoxOutputFonte.ReadOnly = true;
            textBoxOutputFonte.Size = new Size(507, 423);
            textBoxOutputFonte.TabIndex = 7;
            textBoxOutputFonte.TextChanged += textBoxOutputFonte_TextChanged;
            // 
            // FormFonte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxOutputFonte);
            Controls.Add(treeViewFonte);
            Controls.Add(panelTopFonte);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormFonte";
            Padding = new Padding(3, 0, 3, 3);
            ShowInTaskbar = false;
            Text = "FormFonte";
            contextMenuStripFonte.ResumeLayout(false);
            panelTopFonte.ResumeLayout(false);
            panelTopFonte.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStripFonte;
        private ToolStripMenuItem showLogToolStripMenuItem;
        private TreeView treeViewFonte;
        private Panel panelTopFonte;
        private TextBox textBoxSDFonte;
        private TextBox textBoxVersaoFonte;
        private Button buttonReload;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem commitToolStripMenuItem;
        private ToolStripMenuItem switchToolStripMenuItem;
        private ToolStripMenuItem newBranchToolStripMenuItem;
        private TextBox textBoxOutputFonte;
        private ToolStripMenuItem mergeToolStripMenuItem;
        private ToolStripMenuItem openFolderToolStripMenuItem;
    }
}