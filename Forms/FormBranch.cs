using SharpSvn;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Desenvolvimento
{
    public partial class FormBranch : Form
    {
        private readonly Dictionary<string, List<string>> _branches = new();
        private readonly SvnClient _client = new();
        private string _branchURL = string.Empty;

        public FormBranch()
        {
            InitializeComponent();
        }

        [STAThread]
        private static void Thread()
        {
            Application.EnableVisualStyles();
            Application.Run(new FormBranch());
        }

        private void FormBranch_Load(object sender, EventArgs e)
        {
            this.Hide();

            uTils utils = new uTils();
            textBoxVersaoBranch.Text = utils.GetIniParam(IniParamsEnum.DefaultVersion);

            _branchURL = utils.GetIniParam(IniParamsEnum.SVNBranchReview);

            LoadSvnBranches();

            textBoxSDBranch.Focus();

            this.Show();
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            _branches.Clear();
            treeViewBranch.Nodes.Clear();
            LoadSvnBranches();
        }

        private void FiltrarTreeView(string filtro)
        {
            treeViewBranch.Nodes.Clear();

            foreach (var branch in _branches)
            {
                List<string> subBranchesFiltradas = branch.Value.FindAll(s => s.Contains(filtro, StringComparison.OrdinalIgnoreCase));

                if (branch.Key.Contains(filtro, StringComparison.OrdinalIgnoreCase) || subBranchesFiltradas.Count > 0)
                {
                    TreeNode branchNode = new TreeNode(branch.Key);
                    treeViewBranch.Nodes.Add(branchNode);

                    if (!string.IsNullOrEmpty(filtro))
                        branchNode.Expand();

                    foreach (var subBranch in subBranchesFiltradas)
                    {
                        branchNode.Nodes.Add(subBranch);
                        if (!string.IsNullOrEmpty(filtro))
                            branchNode.Expand();
                    }
                }
            }
        }

        private void CarregarTreeView(Dictionary<string, List<string>> branches)
        {
            treeViewBranch.Nodes.Clear();

            foreach (var branch in branches)
            {
                TreeNode branchNode = new TreeNode(branch.Key);
                branchNode.Tag = _branchURL + Path.GetFileName(branch.Key);
                treeViewBranch.Nodes.Add(branchNode);

                foreach (var subBranch in branch.Value)
                {
                    TreeNode subBranchNode = new TreeNode(subBranch);

                    subBranchNode.Tag = branchNode.Tag + "/" + Path.GetFileName(subBranch);

                    branchNode.Nodes.Add(subBranchNode);
                }
            }
        }

        private void LoadSvnBranches()
        {
            uTils utils = new uTils();
            string svnUri = utils.GetIniParam(IniParamsEnum.SVNBranchReview);

            string formEditValue = textBoxVersaoBranch.Text;
            svnUri = $"{svnUri}/{formEditValue}";

            try
            {
                Collection<SvnListEventArgs> list;
                SvnUriTarget target = new SvnUriTarget(new Uri(svnUri));

                string mainFolderName = new Uri(svnUri).Segments.Last().Trim('/');

                if (!String.IsNullOrEmpty(formEditValue))
                {
                    _branches[formEditValue] = new List<string>();
                }

                if (_client.GetList(target, out list))
                {
                    foreach (var item in list)
                    {
                        string branchName = item.Name;

                        if (mainFolderName != branchName && item.Entry.NodeKind == SvnNodeKind.Directory)
                        {
                            if (!String.IsNullOrEmpty(formEditValue))
                            {
                                _branches[formEditValue].Add(branchName);
                            }
                            else
                            {
                                _branches[branchName] = new List<string>();

                                string versionUri = $"{svnUri}/{branchName}";

                                Collection<SvnListEventArgs> subList;
                                SvnUriTarget versionTarget = new SvnUriTarget(new Uri(versionUri));

                                if (_client.GetList(versionTarget, out subList))
                                {
                                    foreach (var subItem in subList)
                                    {
                                        if (subItem.Entry.NodeKind == SvnNodeKind.Directory)
                                        {
                                            _branches[branchName].Add(subItem.Name);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    CarregarTreeView(_branches);
                }
                else
                {
                    MessageBox.Show("Não foi possível obter as branches do repositório SVN.");
                }
            }
            catch (SvnException ex)
            {
                MessageBox.Show($"Erro ao conectar ao repositório SVN: {ex.Message}");
            }
        }

        private void textBoxSDBranch_TextChanged(object sender, EventArgs e)
        {
            FiltrarTreeView(textBoxSDBranch.Text);
        }

        private void showLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewBranch.SelectedNode != null)
            {
                string selectedPath = treeViewBranch.SelectedNode.Tag?.ToString();

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
    }
}
