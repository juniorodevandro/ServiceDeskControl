namespace Desenvolvimento.Forms
{
    public partial class FormDocumentacao : FormBase
    {
        public FormDocumentacao()
        {
            InitializeComponent();

            if (File.Exists(_pathDocumentacao))
            {
                OpenRichEditAsRTF(_pathDocumentacao);
            }
            else
            {
                try
                {
                    File.Create(_pathDocumentacao).Close();
                    MessageBox.Show("O arquivo não existia e foi criado.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao criar o arquivo: {ex.Message}");
                }

                OpenRichEditAsRTF(_pathDocumentacao);
            }

            richTextBox.SelectionStart = 0;
        }

        [STAThread]
        private static void Thread()
        {
            Application.EnableVisualStyles();
            Application.Run(new FormDocumentacao());
        }

        private void OpenRichEditAsRTF(string fileName)
        {
            richTextBox.LoadFile(fileName);
        }

        private void LoadStoryDetails()
        {
            using (OpenFileDialog? openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\temp\\Documentacao\\";
                openFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|Text Files (*.txt)|*.txt";
                openFileDialog.DefaultExt = "rtf";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    switch (openFileDialog.FilterIndex)
                    {
                        case 1:
                            OpenRichEditAsRTF(openFileDialog.FileName);
                            break;
                        case 2:
                            OpenRichEditAsTXT(openFileDialog.FileName);
                            break;
                    }
                }
            }
        }

        private void OpenRichEditAsTXT(string fileName)
        {
            richTextBox.LoadFile(fileName, RichTextBoxStreamType.PlainText);
        }

        private void richTextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.O)
            {
                LoadStoryDetails();
                e.Handled = true;
            }

            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveRichEditAsRTF(_pathDocumentacao);
                e.Handled = true;
            }

            if (e.Control && e.Shift && e.KeyCode == Keys.S)
            {
                SaveDocumentationDetails();
                e.Handled = true;
            }
        }

        private void SaveRichEditAsRTF(string fileName)
        {
            richTextBox.SaveFile(fileName, RichTextBoxStreamType.RichText);
        }

        private void SaveRichEditAsTXT(string fileName)
        {
            richTextBox.SaveFile(fileName, RichTextBoxStreamType.PlainText);
        }

        private void SaveDocumentationDetails()
        {
            using (SaveFileDialog? saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|Text Files (*.txt)|*.txt";
                saveFileDialog.DefaultExt = "rtf";
                saveFileDialog.FilterIndex = 1;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    switch (saveFileDialog.FilterIndex)
                    {
                        case 1:
                            SaveRichEditAsRTF(saveFileDialog.FileName);
                            break;
                        case 2:
                            SaveRichEditAsTXT(saveFileDialog.FileName);
                            break;
                    }
                }
            }
        }
    }
}
