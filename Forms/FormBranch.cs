using SharpSvn;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Desenvolvimento.Forms;

namespace Desenvolvimento
{
    public partial class FormBranch : FormBase
    {
        private readonly Dictionary<string, List<string>> _branches = new();
        private bool _isButtonActive = false;

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

            textBoxVersaoBranch.Text = _defaultVersion;

            LoadSvnBranches();

            textBoxSDBranch.Focus();

            this.Show();
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            _branches.Clear();
            treeViewBranch.Nodes.Clear();
            LoadSvnBranches();

            if (!String.IsNullOrEmpty(textBoxSDBranch.Text))
            {
                FiltrarTreeView(textBoxSDBranch.Text);
            }
        }

        private void FiltrarTreeView(string filtro)
        {
            treeViewBranch.Nodes.Clear();

            foreach (var branch in _branches)
            {
                List<string> subBranchesFiltradas = branch.Value.FindAll(s => s.Contains(filtro, StringComparison.OrdinalIgnoreCase));

                if (branch.Key.Contains(filtro, StringComparison.OrdinalIgnoreCase) || subBranchesFiltradas.Count > 0)
                {
                    string snvUrl = _isButtonActive ? _snvBranch : _snvBranchReview;

                    TreeNode branchNode = new TreeNode(branch.Key);
                    branchNode.Tag = snvUrl + Path.GetFileName(branch.Key);
                    treeViewBranch.Nodes.Add(branchNode);

                    if (!string.IsNullOrEmpty(filtro))
                        branchNode.Expand();

                    foreach (var subBranch in subBranchesFiltradas)
                    {
                        TreeNode subBranchNode = new TreeNode(subBranch);

                        subBranchNode.Tag = branchNode.Tag + "/" + Path.GetFileName(subBranch);

                        branchNode.Nodes.Add(subBranchNode);

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
                string snvUrl = _isButtonActive ? _snvBranch : _snvBranchReview;
                TreeNode branchNode = new TreeNode(branch.Key);
                branchNode.Tag = snvUrl + Path.GetFileName(branch.Key);
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
            string svnUri = _isButtonActive ? _snvBranch : _snvBranchReview;

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

        private void buttonMyBranch_Click(object sender, EventArgs e)
        {
            _isButtonActive = !_isButtonActive;
            buttonMyBranch.BackColor = _isButtonActive ? Color.LightBlue : SystemColors.Control;

            Reload_Click(null, null);
        }

        private void treeViewBranch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 && treeViewBranch.SelectedNode != null)
            {
                treeViewBranch.LabelEdit = true;
                treeViewBranch.SelectedNode.BeginEdit();
            }
        }

        private void treeViewBranch_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            e.CancelEdit = true;

            treeViewBranch.LabelEdit = false;
        }
    }
}
