using Desenvolvimento.Forms;

namespace Desenvolvimento
{
    public partial class FormConfiguracao : FormBase
    {
        private string _iniFilePath;

        private Dictionary<string, string> _configValues;

        public FormConfiguracao()
        {
            InitializeComponent();

            _iniFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config.ini");

            _configValues = new Dictionary<string, string>()
            {
                { "DefaultVersion", "" },
                { "DiretorioFont", "" },
                { "SVNTrunk", "" },
                { "SVNBranch", "" },
                { "SVNBranchReview", "" },
                { "DiretorioDocumentacao", "" },
            };

            ReadIniFile();

            _updateSenha = false;

            BindConfigToDataGridView();
        }

        private void BindConfigToDataGridView()
        {
            dataGridViewConfig.Rows.Clear();

            foreach (var config in _configValues)
            {
                int rowIndex = dataGridViewConfig.Rows.Add(config.Key, config.Value);

                DataGridViewRow row = dataGridViewConfig.Rows[rowIndex];

                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = SystemColors.ControlDark;
                }
            }
        }

        private void ReadIniFile()
        {
            if (File.Exists(_iniFilePath))
            {
                foreach (var line in File.ReadAllLines(_iniFilePath))
                {
                    if (line.StartsWith("[PARAMETROS]")) continue;

                    var parts = line.Split('=');
                    if (parts.Length == 2)
                    {
                        var key = parts[0].Trim();
                        var value = parts[1].Trim();
                        if (_configValues.ContainsKey(key))
                        {
                            _configValues[key] = value;
                        }
                    }
                }
            }
        }

        private void WriteIniFile()
        {
            using (var writer = new StreamWriter(_iniFilePath))
            {
                writer.WriteLine("[PARAMETROS]");
                foreach (var config in _configValues)
                {
                    writer.WriteLine($"{config.Key}={config.Value}");
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewConfig.Rows)
            {
                if (row.Index == dataGridViewConfig.NewRowIndex) continue;

                var key = row.Cells[0].Value?.ToString();
                var value = row.Cells[1].Value?.ToString();
                if (!string.IsNullOrEmpty(key) && _configValues.ContainsKey(key))
                {
                    _configValues[key] = value;
                }
            }

            WriteIniFile();

            LoadIniParams();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            ReadIniFile();
            BindConfigToDataGridView();
        }
    }
}