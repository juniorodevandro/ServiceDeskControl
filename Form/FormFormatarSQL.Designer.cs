namespace Desenvolvimento
{
    partial class FormFormatarSQL
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
            richTextBoxFormatarSQL = new RichTextBox();
            panelBottom = new Panel();
            buttonFormatar = new Button();
            buttonFormatarDelphi = new Button();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBoxFormatarSQL
            // 
            richTextBoxFormatarSQL.AcceptsTab = true;
            richTextBoxFormatarSQL.AutoWordSelection = true;
            richTextBoxFormatarSQL.BackColor = SystemColors.ControlDark;
            richTextBoxFormatarSQL.BorderStyle = BorderStyle.None;
            richTextBoxFormatarSQL.Dock = DockStyle.Fill;
            richTextBoxFormatarSQL.Font = new Font("Segoe UI", 12F);
            richTextBoxFormatarSQL.Location = new Point(3, 0);
            richTextBoxFormatarSQL.Margin = new Padding(0);
            richTextBoxFormatarSQL.Name = "richTextBoxFormatarSQL";
            richTextBoxFormatarSQL.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBoxFormatarSQL.Size = new Size(794, 418);
            richTextBoxFormatarSQL.TabIndex = 2;
            richTextBoxFormatarSQL.TabStop = false;
            richTextBoxFormatarSQL.Text = "";
            // 
            // panelBottom
            // 
            panelBottom.BackColor = SystemColors.ControlDark;
            panelBottom.BorderStyle = BorderStyle.FixedSingle;
            panelBottom.Controls.Add(buttonFormatar);
            panelBottom.Controls.Add(buttonFormatarDelphi);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(3, 418);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(0, 2, 10, 3);
            panelBottom.RightToLeft = RightToLeft.Yes;
            panelBottom.Size = new Size(794, 29);
            panelBottom.TabIndex = 3;
            // 
            // buttonFormatar
            // 
            buttonFormatar.BackColor = SystemColors.Control;
            buttonFormatar.Dock = DockStyle.Right;
            buttonFormatar.FlatAppearance.BorderColor = Color.Yellow;
            buttonFormatar.FlatStyle = FlatStyle.System;
            buttonFormatar.Location = new Point(632, 2);
            buttonFormatar.Margin = new Padding(3, 5, 3, 3);
            buttonFormatar.Name = "buttonFormatar";
            buttonFormatar.Size = new Size(75, 22);
            buttonFormatar.TabIndex = 1;
            buttonFormatar.Text = "Formatar";
            buttonFormatar.UseVisualStyleBackColor = false;
            // 
            // buttonFormatarDelphi
            // 
            buttonFormatarDelphi.BackColor = SystemColors.Control;
            buttonFormatarDelphi.Dock = DockStyle.Right;
            buttonFormatarDelphi.FlatStyle = FlatStyle.System;
            buttonFormatarDelphi.Location = new Point(707, 2);
            buttonFormatarDelphi.Margin = new Padding(3, 5, 3, 3);
            buttonFormatarDelphi.Name = "buttonFormatarDelphi";
            buttonFormatarDelphi.Size = new Size(75, 22);
            buttonFormatarDelphi.TabIndex = 2;
            buttonFormatarDelphi.Text = "Delphi";
            buttonFormatarDelphi.UseVisualStyleBackColor = false;
            // 
            // FormFormatarSQL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBoxFormatarSQL);
            Controls.Add(panelBottom);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormFormatarSQL";
            Padding = new Padding(3, 0, 3, 3);
            Text = "FormatarSQL";
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxFormatarSQL;
        private Panel panelBottom;
        private Button buttonFormatar;
        private Button buttonFormatarDelphi;
    }
}