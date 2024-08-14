using Desenvolvimento.Enums;
using Desenvolvimento.Forms;
using Microsoft.VisualBasic;
using SharpSvn;
using System.Diagnostics;

namespace Desenvolvimento
{
    public partial class FormFonte : FormBase
    {
        private List<string> _fontes = new();

        public FormFonte()
        {
            InitializeComponent();

            textBoxVersaoFonte.Text = _defaultVersion;

            buttonReload_Click(null, null);
        }

        [STAThread]
        private static void Thread()
        {
            Application.EnableVisualStyles();
            Application.Run(new FormFonte());
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            treeViewFonte.Nodes.Clear();
            textBoxOutputFonte.Clear();

            TreeNode rootNode = new(_pathFont);
            LoadSubDirectories(_pathFont, null);
        }
        
        private void treeViewFonte_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.Node.Level == 0)
                {
                    treeViewFonte.SelectedNode = e.Node;
                    contextMenuStripFonte.Show(treeViewFonte, e.Location);
                }
                else
                {
                    contextMenuStripFonte.Hide();
                }
            }
        }

        private void showLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewFonte.SelectedNode != null)
            {
                string selectedPath = treeViewFonte.SelectedNode.Tag?.ToString();

                if (!string.IsNullOrEmpty(selectedPath))
                {
                    try
                    {
                        Process.Start("TortoiseProc.exe", $"/command:log /path:\"{selectedPath}\"");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao abrir o log: {ex.Message}");
                    }
                }
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxOutputFonte.Clear();

            if (treeViewFonte.SelectedNode != null)
            {
                string selectedPath = treeViewFonte.SelectedNode.Tag?.ToString();

                if (!string.IsNullOrEmpty(selectedPath))
                {
                    try
                    {
                        List<string> updatedFiles = new();

                        updatedFiles.Add(selectedPath);

                        _client.Notify += (sender, e) =>
                        {
                            if (e.NodeKind == SvnNodeKind.File)
                            {
                                switch (e.Action)
                                {
                                    case SvnNotifyAction.UpdateUpdate:
                                        updatedFiles.Add($"U: {e.Path.Replace(selectedPath, "")}");
                                        break;

                                    case SvnNotifyAction.UpdateAdd:
                                        updatedFiles.Add($"A: {e.Path.Replace(selectedPath, "")}");
                                        break;

                                    case SvnNotifyAction.UpdateDelete:
                                        updatedFiles.Add($"D: {e.Path.Replace(selectedPath, "")}");
                                        break;
                                }
                            }
                        };

                        _client.Update(selectedPath);

                        foreach (string file in updatedFiles)
                        {
                            textBoxOutputFonte.Text += $"{file} \r\n \r\n";
                        }

                        int linhasVisiveis = textBoxOutputFonte.Height / textBoxOutputFonte.Font.Height;

                        int linhasTotais = textBoxOutputFonte.Lines.Length;

                        if (linhasTotais > linhasVisiveis)
                        {
                            textBoxOutputFonte.ScrollBars = ScrollBars.Vertical;
                        }
                        else
                        {
                            textBoxOutputFonte.ScrollBars = ScrollBars.None;
                        }

                    }
                    catch (Exception ex)
                    {
                        textBoxOutputFonte.Text = $"Erro ao executar o update: {ex.Message}";
                    }
                }
            }
        }

        private void commitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewFonte.SelectedNode != null)
            {
                string selectedPath = treeViewFonte.SelectedNode.Tag?.ToString();

                if (!string.IsNullOrEmpty(selectedPath))
                {
                    try
                    {
                        Process.Start("TortoiseProc.exe", $"/command:commit /path:\"{selectedPath}\"");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao abrir o commit: {ex.Message}");
                    }
                }
            }
        }

        private void newBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxVersaoFonte.Text))
            {
                MessageBox.Show($"Versão não informada my friend");
                textBoxVersaoFonte.Focus();
                return;
            }

            using (var renameForm = new FormDialog("Número SD"))
            {
                if (renameForm.ShowDialog(this) == DialogResult.OK)
                {
                    ExecuteSvnCopy(renameForm.TextOutput);
                }
            }
        }

        private void switchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxVersaoFonte.Text))
            {
                MessageBox.Show($"Versão não informada my friend");
                textBoxVersaoFonte.Focus();
                return;
            }

            using (var renameForm = new FormDialog("Número SD"))
            {
                string input = "";
                DialogResult result = renameForm.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    input = renameForm.TextOutput;
                }
                else if (result == DialogResult.Cancel) { return; };

                ExecuteSvnSwitch(input);       
            }
        }
        
        private void ExecuteSvnCopy(string value)
        {
            try
            {
                string branchUrlString = _snvBranch + textBoxVersaoFonte.Text + "/" + value;
                string trunkUrlString = _snvTrunk;
                long revision = 0;

                SvnInfoEventArgs info;
                if (_client.GetInfo(trunkUrlString, out info))
                {
                    revision = info.LastChangeRevision;
                }
                else
                {
                    throw new Exception("Não foi possível obter a última revision." + trunkUrlString);
                }

                string command = $"svn copy {trunkUrlString} {branchUrlString} -m \"SD: {value}\" -r {revision}";


                textBoxOutputFonte.Text = _utils.ExecuteCommand(command);

                ExecuteSvnSwitch(value);

            }
            catch (SvnException ex)
            {
                MessageBox.Show($"Não foi possível obter informações do repositório: {ex.Message}");

            }
        }
        
        private void ExecuteSvnSwitch(string value)
        {
            try
            {
                if (treeViewFonte.SelectedNode != null)
                {
                    string selectedPath = treeViewFonte.SelectedNode.Tag?.ToString();

                    if (string.IsNullOrEmpty(selectedPath))
                    {
                        return;
                    }

                    if (!string.IsNullOrEmpty(value)) { 
                        string branchUrlString = _snvBranch + textBoxVersaoFonte.Text + "/" + value;

                        string command = $"svn switch {branchUrlString}";

                        string output = _utils.ExecuteCommand(command, selectedPath);

                        if (!string.IsNullOrEmpty(output))
                        {
                            textBoxOutputFonte.Text = $"Switch executado com Sucesso: {output}";

                            buttonReload_Click(null, null);
                        }
                        else
                        {
                            textBoxOutputFonte.Text = $"Erro ao executar o comando Switch: {command}";
                        }
                    }
                    else
                    {
                        string command = $"svn switch {_snvTrunk}";

                        string output = _utils.ExecuteCommand(command, selectedPath);

                        if (!string.IsNullOrEmpty(output))
                        {
                            textBoxOutputFonte.Text = $"Switch executado com Sucesso na Trunk: {output}";

                            buttonReload_Click(null, null);
                        }
                        else
                        {
                            textBoxOutputFonte.Text = $"Erro ao executar o comando Switch: {command}";
                        }
                    }
                }

            }
            catch (SvnException ex)
            {
                MessageBox.Show($"Não foi possível obter informações do repositório: {ex.Message}");
            }
        }
        
        private void LoadSubDirectories(string path, TreeNode parentNode)
        {
            try
            {
                string[] subDirectories = Directory.GetDirectories(path);
                foreach (string subDirectory in subDirectories)
                {
                    TreeNode directoryNode = new(Path.GetFileName(subDirectory));
                    directoryNode.Tag = subDirectory;

                    if (!IsBranch(subDirectory))
                        directoryNode.Text += " ***";

                    if (parentNode == null)
                    {
                        treeViewFonte.Nodes.Add(directoryNode);
                        directoryNode.Nodes.Add(new TreeNode("Branch"));
                    }
                    else
                    {
                        parentNode.Nodes.Add(directoryNode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        
        private bool IsBranch(string caminhoPasta)
        {
            SvnInfoEventArgs infoPasta;
            if (_client.GetInfo(caminhoPasta, out infoPasta))
            {
                string urlPasta = infoPasta.Uri.ToString();
                string urlTrunk = _snvTrunk;

                return !(urlPasta.Contains("fontes/branches/desenvolvimento/", StringComparison.OrdinalIgnoreCase));
            }
            else
            {
                return false;
            }
        }
    }
}
