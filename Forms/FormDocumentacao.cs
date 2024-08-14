using Desenvolvimento.Forms;
using Desenvolvimento.Custom;
using System.Xml.Serialization;
using Desenvolvimento.Shared;
using System.Reflection.Metadata.Ecma335;

namespace Desenvolvimento
{
    public partial class FormDocumentacao : FormBase
    {
        private List<RichTextBox> richTextBoxes = new List<RichTextBox>();

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

        private void LoadTabs()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<TabData>));
                using (StreamReader reader = new StreamReader("tabs.xml"))
                {
                    List<TabData> tabDataList = (List<TabData>)serializer.Deserialize(reader);

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

            XmlSerializer serializer = new XmlSerializer(typeof(List<TabData>));
            using (StreamWriter writer = new StreamWriter("tabs.xml"))
            {
                serializer.Serialize(writer, tabDataList);
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

            using (var renameForm = new FormTabRename(tabPage.Text))
            {
                if (renameForm.ShowDialog(this) == DialogResult.OK)
                {
                    tabPage.Text = renameForm.NewTabName;
                }
            }
        }

        private void FormUserStory_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTabs();
        }

        private void TabPage_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                TabPage tabPage = (TabPage)sender;
                tabControl.TabPages.Remove(tabPage);
            }
        }

        private void tabControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CriarNovaAba();
        }

        private void richTextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (!e.Control) { return; }

            RichTextBox richText = (RichTextBox)sender;

            switch (e.KeyCode)
            {
                case Keys.B:
                    StringToBold(richText);
                    e.Handled = true;
                    break;

                case Keys.D:
                    StringToRed(richText);
                    e.Handled = true;
                    break;

                case Keys.F:
                    StringToGreen(richText);
                    e.Handled = true;
                    break;

                case Keys.T:
                    MarkAsCompleted(richText);
                    e.Handled = true;
                    break;

                case Keys.O:
                    //LoadStoryDetails();
                    e.Handled = true;
                    break;

                case Keys.S:
                    if (!e.Shift) { return; }

                    SaveFile(richText);
                    e.Handled = true;
                    break;
            }
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
        }
    }
}