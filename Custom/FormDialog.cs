public class FormDialog : Form
{
    public string TextOutput => textBoxTabName.Text;

    private TextBox textBoxTabName;
    private Button buttonOk;
    private Button buttonCancel;

    public FormDialog(string caption, string currentName = "", bool visibleTextBox = true)
    {
        InitializeComponent(caption);
        textBoxTabName.Text = currentName;

        textBoxTabName.Visible = visibleTextBox;

        if (!visibleTextBox)
        {
            this.ClientSize = new System.Drawing.Size(160, 30);
        }
    }

    private void InitializeComponent(string caption)
    {
        textBoxTabName = new TextBox
        {
            Dock = DockStyle.Top,
            Margin = new Padding(10)
        };

        buttonOk = new Button
        {
            Text = "OK",
            DialogResult = DialogResult.OK,
            Dock = DockStyle.Left
        };

        buttonCancel = new Button
        {
            Text = "Cancel",
            DialogResult = DialogResult.Cancel,
            Dock = DockStyle.Right
        };

        buttonOk.Click += (sender, e) => { this.DialogResult = DialogResult.OK; this.Close(); };
        buttonCancel.Click += (sender, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };

        TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
        tableLayoutPanel.RowCount = 2;
        tableLayoutPanel.ColumnCount = 2;
        tableLayoutPanel.Dock = DockStyle.Fill;

        tableLayoutPanel.Controls.Add(textBoxTabName, 0, 0);
        tableLayoutPanel.SetColumnSpan(textBoxTabName, 2); 

        tableLayoutPanel.Controls.Add(buttonOk, 0, 1);
        tableLayoutPanel.Controls.Add(buttonCancel, 1, 1);

        this.Controls.Add(tableLayoutPanel);

        this.StartPosition = FormStartPosition.CenterParent;
        this.ClientSize = new System.Drawing.Size(160, 70);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.AcceptButton = buttonOk;
        this.CancelButton = buttonCancel;
        this.Text = caption;
    }
}
