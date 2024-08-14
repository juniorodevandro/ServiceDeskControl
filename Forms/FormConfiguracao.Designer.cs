namespace Desenvolvimento
{
    partial class FormConfiguracao
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
            dataGridViewConfig = new DataGridView();
            Key = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            buttonSalvar = new Button();
            panelBottom = new Panel();
            buttonCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConfig).BeginInit();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewConfig
            // 
            dataGridViewConfig.AllowUserToAddRows = false;
            dataGridViewConfig.AllowUserToDeleteRows = false;
            dataGridViewConfig.AllowUserToResizeRows = false;
            dataGridViewConfig.BorderStyle = BorderStyle.None;
            dataGridViewConfig.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewConfig.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConfig.Columns.AddRange(new DataGridViewColumn[] { Key, Value });
            dataGridViewConfig.Dock = DockStyle.Fill;
            dataGridViewConfig.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewConfig.Location = new Point(3, 0);
            dataGridViewConfig.Name = "dataGridViewConfig";
            dataGridViewConfig.RowHeadersVisible = false;
            dataGridViewConfig.Size = new Size(794, 447);
            dataGridViewConfig.TabIndex = 0;
            dataGridViewConfig.TabStop = false;
            // 
            // Key
            // 
            Key.FillWeight = 200F;
            Key.Frozen = true;
            Key.HeaderText = "Propriedade";
            Key.Name = "Key";
            Key.ReadOnly = true;
            Key.Width = 200;
            // 
            // Value
            // 
            Value.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Value.HeaderText = "Valor";
            Value.Name = "Value";
            Value.Resizable = DataGridViewTriState.False;
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = SystemColors.Control;
            buttonSalvar.Dock = DockStyle.Right;
            buttonSalvar.FlatStyle = FlatStyle.System;
            buttonSalvar.Location = new Point(707, 2);
            buttonSalvar.Margin = new Padding(3, 5, 3, 3);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 22);
            buttonSalvar.TabIndex = 2;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += btnSalvar_Click;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = SystemColors.ControlDark;
            panelBottom.BorderStyle = BorderStyle.FixedSingle;
            panelBottom.Controls.Add(buttonCancelar);
            panelBottom.Controls.Add(buttonSalvar);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(3, 418);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(0, 2, 10, 3);
            panelBottom.Size = new Size(794, 29);
            panelBottom.TabIndex = 2;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = SystemColors.Control;
            buttonCancelar.Dock = DockStyle.Right;
            buttonCancelar.FlatAppearance.BorderColor = Color.Yellow;
            buttonCancelar.FlatStyle = FlatStyle.System;
            buttonCancelar.Location = new Point(632, 2);
            buttonCancelar.Margin = new Padding(3, 5, 3, 3);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 22);
            buttonCancelar.TabIndex = 1;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // FormConfiguracao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelBottom);
            Controls.Add(dataGridViewConfig);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormConfiguracao";
            Padding = new Padding(3, 0, 3, 3);
            Text = "FormConfiguracao";
            ((System.ComponentModel.ISupportInitialize)dataGridViewConfig).EndInit();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewConfig;
        private Button buttonSalvar;
        private Panel panelBottom;
        private Button buttonCancelar;
        private DataGridViewTextBoxColumn Key;
        private DataGridViewTextBoxColumn Value;
    }
}