namespace Desenvolvimento
{
    partial class FormUserStory
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
            richTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBox
            // 
            richTextBox.AcceptsTab = true;
            richTextBox.BackColor = SystemColors.ControlDark;
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.EnableAutoDragDrop = true;
            richTextBox.Font = new Font("Segoe UI", 12F);
            richTextBox.Location = new Point(3, 0);
            richTextBox.Name = "richTextBox";
            richTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox.Size = new Size(794, 450);
            richTextBox.TabIndex = 1;
            richTextBox.Text = "";
            richTextBox.KeyDown += richTextBoxKeyUp;
            // 
            // FormDocumentacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDocumentacao";
            Padding = new Padding(3, 0, 3, 0);
            Text = "FormDocumentacao";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox;
    }
}