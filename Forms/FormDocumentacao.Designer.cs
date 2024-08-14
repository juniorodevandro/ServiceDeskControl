namespace Desenvolvimento
{
    partial class FormDocumentacao
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
            contextMenuStrip = new ContextMenuStrip(components);
            tabControl = new TabControl();
            TabDefault = new TabPage();
            richTextBoxDefault = new RichTextBox();
            tabControl.SuspendLayout();
            TabDefault.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(61, 4);
            // 
            // tabControl
            // 
            tabControl.Controls.Add(TabDefault);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(3, 0);
            tabControl.Margin = new Padding(0, 0, 3, 3);
            tabControl.Name = "tabControl";
            tabControl.Padding = new Point(0, 0);
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(794, 450);
            tabControl.TabIndex = 2;
            tabControl.MouseDoubleClick += tabControl_MouseDoubleClick;
            tabControl.MouseDown += tabControl_MouseDown;
            // 
            // TabDefault
            // 
            TabDefault.BackColor = Color.WhiteSmoke;
            TabDefault.Controls.Add(richTextBoxDefault);
            TabDefault.Location = new Point(4, 24);
            TabDefault.Margin = new Padding(0);
            TabDefault.Name = "TabDefault";
            TabDefault.Size = new Size(786, 422);
            TabDefault.TabIndex = 0;
            TabDefault.Text = "Tab";
            // 
            // richTextBoxDefault
            // 
            richTextBoxDefault.AcceptsTab = true;
            richTextBoxDefault.BackColor = SystemColors.ControlDark;
            richTextBoxDefault.Dock = DockStyle.Fill;
            richTextBoxDefault.EnableAutoDragDrop = true;
            richTextBoxDefault.Font = new Font("Segoe UI", 12F);
            richTextBoxDefault.Location = new Point(0, 0);
            richTextBoxDefault.Name = "richTextBoxDefault";
            richTextBoxDefault.Size = new Size(786, 422);
            richTextBoxDefault.TabIndex = 2;
            richTextBoxDefault.Text = "";
            richTextBoxDefault.KeyUp += richTextBoxKeyUp;
            // 
            // FormDocumentacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = contextMenuStrip;
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDocumentacao";
            Padding = new Padding(3, 0, 3, 0);
            Text = "FormDocumentacao";
            FormClosing += FormUserStory_FormClosing;
            tabControl.ResumeLayout(false);
            TabDefault.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip;
        private TabControl tabControl;
        private TabPage TabDefault;
        private RichTextBox richTextBoxDefault;
    }
}