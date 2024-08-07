using Microsoft.VisualBasic;
using ReaLTaiizor.Enum.Crown;
using SharpSvn;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace Desenvolvimento
{
    public partial class FormFonte : Form
    {
        private uTils _utils = new uTils();
        private SvnClient _client = new SvnClient();
        private List<string> _fontes = new List<string>();
        private string _rootPath = string.Empty;

        public FormFonte()
        {
            InitializeComponent();

            textBoxVersaoFonte.Text = _utils.GetIniParam(IniParamsEnum.DefaultVersion);

            buttonReload_Click(null, null);
        }

        [STAThread]
        private static void Thread()
        {
            Application.EnableVisualStyles();
            Application.Run(new FormFonte());
        }

        private bool IsBranch(string caminhoPasta)
        {
            SvnInfoEventArgs infoPasta;
            if (_client.GetInfo(caminhoPasta, out infoPasta))
            {
                string urlPasta = infoPasta.Uri.ToString();
                string urlTrunk = _utils.GetIniParam(IniParamsEnum.SVNTrunk);

                return !(urlPasta.Contains("fontes/branches/desenvolvimento/", StringComparison.OrdinalIgnoreCase));
            }
            else
            {
                return false;
            }
        }


        private void LoadSubDirectories(string path, TreeNode parentNode)
        {
            try
            {
                string[] subDirectories = Directory.GetDirectories(path);
                foreach (string subDirectory in subDirectories)
                {
                    TreeNode directoryNode = new TreeNode(Path.GetFileName(subDirectory));
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

        private void buttonReload_Click(object sender, EventArgs e)
        {
            treeViewFonte.Nodes.Clear();

            _rootPath = _utils.GetIniParam(IniParamsEnum.DiretorioBranch);

            TreeNode rootNode = new TreeNode(_rootPath);
            LoadSubDirectories(_rootPath, null);
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

        private void ExecuteSvnCopy(string message)
        {
            try
            {
                string branchUrlString = _utils.GetIniParam(IniParamsEnum.SVNBranch) + textBoxVersaoFonte.Text + "/" + message;
                string trunkUrlString = _utils.GetIniParam(IniParamsEnum.SVNTrunk);
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

                string command = $"svn copy {trunkUrlString} {branchUrlString} -m \"SD: {message}\" -r {revision}";


                textBoxOutputFonte.Text = _utils.ExecuteCommand(command);

                ExecuteSvnSwitch(message);

            }
            catch (SvnException ex)
            {
                MessageBox.Show($"Não foi possível obter informações do repositório: {ex.Message}");

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

            string input = Interaction.InputBox("Número SD", "SD", "", -1, -1);

            if (input != null)
            {
                ExecuteSvnCopy(input);
            }
        }

        private void ExecuteSvnSwitch(string message)
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

                    if (!string.IsNullOrEmpty(message)) { 
                        string branchUrlString = _utils.GetIniParam(IniParamsEnum.SVNBranch) + textBoxVersaoFonte.Text + "/" + message;

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
                        string command = $"svn switch {_utils.GetIniParam(IniParamsEnum.SVNTrunk)}";

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

        private void switchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxVersaoFonte.Text))
            {
                MessageBox.Show($"Versão não informada my friend");
                textBoxVersaoFonte.Focus();
                return;
            }

            string input = Interaction.InputBox("Número SD", "SD", "", -1, -1);

            ExecuteSvnSwitch(input);            
        }
    }
}
