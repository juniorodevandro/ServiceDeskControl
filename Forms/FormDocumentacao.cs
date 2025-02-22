﻿using Desenvolvimento.Custom;
using Desenvolvimento.Forms;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Desenvolvimento
{
    public partial class FormDocumentacao : FormBase
    {
        private List<RichTextBox> richTextBoxes = new List<RichTextBox>();

        private TabPage draggingTab;
        private Point _mouseDownPoint;
        private int _draggedTabIndex = -1;

        public FormDocumentacao()
        {
            InitializeComponent();

            LoadTabs();

            tabControl.SelectedIndex = 0;
        }

        [STAThread]
        private static void Thread()
        {
            Application.EnableVisualStyles();
            Application.Run(new FormDocumentacao());
        }

        private void CriarNovaAba()
        {
            RichTextBoxCustom richTextBox = new(richTextBoxDefault);
            richTextBox.KeyUp += richTextBoxKeyUp;

            TabPage tabPage = new TabPage("New Tab " + tabControl.TabCount);
            tabPage.Controls.Add(richTextBox);

            tabControl.TabPages.Add(tabPage);

            richTextBoxes.Add(richTextBox);

            tabControl.SelectedTab = tabPage;

            richTextBox.Focus();
        }

        private void RemoverAba()
        {
            int indexPage = tabControl.SelectedIndex;
            if (tabControl.TabPages[indexPage].Name != "TabDefault")
            {
                var richTextBox = tabControl.TabPages[indexPage].Controls.OfType<RichTextBox>().FirstOrDefault();

                bool remove = true;
                if (richTextBox != null && !string.IsNullOrWhiteSpace(richTextBox.Text))
                {
                    using (var form = new FormDialog("Fechar?", "", false))
                    {
                        string output = "";
                        DialogResult result = form.ShowDialog(this);

                        if (result == DialogResult.OK)
                        {
                            output = form.TextOutput;
                        }
                        else if (result == DialogResult.Cancel) { return; };
                    }
                }

               if (!remove) return;

               tabControl.TabPages.RemoveAt(indexPage);
               tabControl.SelectedIndex = indexPage - 1;
            }
        }

        private void LoadTabs()
        {
            try
            {
                using (StreamReader reader = new StreamReader("tabs.json"))
                {
                    string json = reader.ReadToEnd();
                    List<TabData> tabDataList = JsonSerializer.Deserialize<List<TabData>>(json);

                    if (tabControl.TabPages.ContainsKey("TabDefault"))
                    {
                        if (tabDataList.Count > 0)
                        {
                            RichTextBox defaultRichTextBox = (RichTextBox)tabControl.TabPages["TabDefault"].Controls[0];
                            defaultRichTextBox.Rtf = tabDataList[0].Rtf;

                            tabDataList.RemoveAt(0);
                        }
                    }

                    foreach (TabData tabData in tabDataList)
                    {
                        CriarNovaAba();
                        richTextBoxes[richTextBoxes.Count - 1].Rtf = tabData.Rtf;
                        tabControl.TabPages[tabControl.TabCount - 1].Text = tabData.TabName;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                if (!tabControl.TabPages.ContainsKey("TabDefault"))
                {
                    CriarNovaAba();
                }
            }
        }

        private void SaveTabs()
        {
            List<TabData> tabDataList = new List<TabData>();

            foreach (TabPage tabPage in tabControl.TabPages)
            {
                RichTextBox richTextBox = (RichTextBox)tabPage.Controls[0];
                tabDataList.Add(new TabData { Rtf = richTextBox.Rtf, TabName = tabPage.Text });
            }

            string json = JsonSerializer.Serialize(tabDataList, new JsonSerializerOptions { WriteIndented = true });
            using (StreamWriter writer = new StreamWriter("tabs.json"))
            {
                writer.Write(json);
            }
        }

        public class TabData
        {
            public string? Rtf { get; set; }
            public string? TabName { get; set; }
        }

        private void ShowFormTabRename(int tabIndex)
        {
            TabPage tabPage = tabControl.TabPages[tabIndex];

            using (var renameForm = new FormDialog("Rename Tab", tabPage.Text))
            {
                if (renameForm.ShowDialog(this) == DialogResult.OK)
                {
                    tabPage.Text = renameForm.TextOutput;
                }
            }
        }

        private void FormUserStory_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTabs();
        }

        private void tabControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CriarNovaAba();
        }

        private void richTextBoxKeyUp(object sender, KeyEventArgs e)
        {
            RichTextBox richText = (RichTextBox)sender;

            if (e.KeyCode == Keys.F3)
            {
                SearchAndSelectedText(richText);
                e.Handled = true;
            }

            if (!e.Control) { return; }

            switch (e.KeyCode)
            {
                case Keys.B:
                    StringToBold(richText);
                    e.Handled = true;
                    break;

                case Keys.T:
                    StringToRed(richText);
                    e.Handled = true;
                    break;

                case Keys.F:
                    SearchAndSelectedText(richText);
                    e.Handled = true;
                    break;

                case Keys.D:
                    StringToGreen(richText);
                    e.Handled = true;
                    break;

                case Keys.Oem2:
                    MarkAsCompleted(richText);
                    e.Handled = true;
                    break;

                case Keys.O:
                    e.Handled = true;
                    break;

                case Keys.S:
                    if (!e.Shift)
                    {
                        SaveFile(richText);
                    }
                    else
                    {
                       SaveTabs();
                    }

                    e.Handled = true;
                    break;

                case Keys.N:
                    CriarNovaAba();
                    e.Handled = true;
                    break;

                case Keys.W:
                    RemoverAba();
                    e.Handled = true;
                    break;
            }
        }

        private int GetTabIndexAtPoint(Point pt)
        {
            for (int i = 0; i < tabControl.TabCount; i++)
            {
                if (tabControl.GetTabRect(i).Contains(pt))
                {
                    return i;
                }
            }
            return -1;
        }

        private void tabControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                for (int i = 0; i < tabControl.TabCount; i++)
                {
                    Rectangle tabRect = tabControl.GetTabRect(i);
                    if (tabRect.Contains(e.Location))
                    {
                        if (tabControl.TabPages[i].Name != "TabDefault")
                        {
                            var richTextBox = tabControl.TabPages[i].Controls.OfType<RichTextBox>().FirstOrDefault();
                            bool remove = true;
                            if (richTextBox != null && !string.IsNullOrWhiteSpace(richTextBox.Text))
                            {
                                using (var form = new FormDialog("Fechar?", "", false))
                                {
                                    string output = "";
                                    DialogResult result = form.ShowDialog(this);

                                    if (result == DialogResult.OK)
                                    {
                                        output = form.TextOutput;
                                    }
                                    else if (result == DialogResult.Cancel) { return; };
                                }
                            }

                            if (!remove) return;

                            tabControl.TabPages.RemoveAt(i);

                            tabControl.SelectedIndex = i - 1;
                        }
                        break;
                    }
                }
            }

            int indexPage = tabControl.SelectedIndex;
            if (indexPage > -1 && tabControl.TabPages[indexPage].Name != "TabDefault")
            {
                if (e.Button == MouseButtons.Right)
                {
                    ShowFormTabRename(indexPage);
                }
            }

            if (e.Button == MouseButtons.Left)
            {
                _mouseDownPoint = e.Location;
                _draggedTabIndex = GetTabIndexAtPoint(e.Location); // Define o índice aqui
            }
        }

        private void tabControl_KeyUp(object sender, KeyEventArgs e)
        {
            if (!e.Control) { return; }

            switch (e.KeyCode)
            {
                case Keys.N:
                    CriarNovaAba();
                    e.Handled = true;
                    break;

                case Keys.W:
                    RemoverAba();
                    e.Handled = true;
                    break;
            }
        }

        private void tabControl_DragDrop(object sender, DragEventArgs e)
        {
            if (_draggedTabIndex < 0) return;

            TabPage draggedTab = (TabPage)e.Data.GetData(typeof(TabPage));
            int targetIndex = GetTabIndexAtPoint(tabControl.PointToClient(new Point(e.X, e.Y)));

            if (targetIndex >= 0 && targetIndex != _draggedTabIndex && draggedTab != null)
            {
                tabControl.TabPages.RemoveAt(_draggedTabIndex);

                if (targetIndex > _draggedTabIndex)
                {
                    targetIndex--;
                }

                tabControl.TabPages.Insert(targetIndex, draggedTab);
                tabControl.SelectedTab = draggedTab;
            }

            _draggedTabIndex = -1;
        }

        private void tabControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || _draggedTabIndex < 0) return;

            if (e.Location != _mouseDownPoint)
            {
                tabControl.DoDragDrop(tabControl.TabPages[_draggedTabIndex], DragDropEffects.Move);
            }
        }

        private void tabControl_DragOver(object sender, DragEventArgs e)
        {
            if (_draggedTabIndex < 0) return;

            Point pt = tabControl.PointToClient(new Point(e.X, e.Y));
            int targetIndex = GetTabIndexAtPoint(pt);

            if (targetIndex >= 0 && targetIndex != _draggedTabIndex)
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}