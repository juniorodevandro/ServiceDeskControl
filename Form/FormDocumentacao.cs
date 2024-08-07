namespace Desenvolvimento
{
    public partial class FormDocumentacao : Form
    {
        uTils utils = new();
        private string _pathUserStory = string.Empty;
        private const string TextDefatultUserStory = "## Objetivo da solicitação ##,## Como está atualmente ##,## Como deve ser ##,## Sequência de alteração ##,## Termo de aceite ##";

        public FormDocumentacao()
        {
            InitializeComponent();

            _pathUserStory = utils.GetIniParam(IniParamsEnum.DiretorioUserStory);

            if (File.Exists(_pathUserStory))
            {
                OpenRichEditAsRTF(_pathUserStory);
            }
            else
            {
                try
                {
                    File.Create(_pathUserStory).Close();
                    MessageBox.Show("O arquivo não existia e foi criado.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao criar o arquivo: {ex.Message}");
                }

                OpenRichEditAsRTF(_pathUserStory);
            }

            richTextBox.SelectionStart = 0;
        }

        [STAThread]
        private static void Thread()
        {
            Application.EnableVisualStyles();
            Application.Run(new FormDocumentacao());
        }

        private void ApplyBoldToLinesContainingWord()
        {
            string[] titulos = TextDefatultUserStory.Split(',');

            int currentCharIndex = 0;

            for (int i = 0; i < richTextBox.Lines.Length; i++)
            {
                string line = richTextBox.Lines[i];

                foreach (var titulo in titulos)
                {
                    if (line.Contains(titulo))
                    {
                        richTextBox.Select(currentCharIndex, line.Length);

                        if (richTextBox.SelectionFont != null)
                        {
                            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, FontStyle.Bold);
                        }
                        break;
                    }
                }

                currentCharIndex += line.Length + 1;
            }

            richTextBox.SelectionStart = 0;
            richTextBox.SelectionLength = 0;
        }


        private void LoadStoryDetails()
        {
            using (OpenFileDialog? openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\temp\\UserStory\\";
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

        private void OpenRichEditAsRTF(string fileName)
        {
            richTextBox.LoadFile(fileName, RichTextBoxStreamType.RichText);
            ApplyBoldToLinesContainingWord();
        }

        private void OpenRichEditAsTXT(string fileName)
        {
            richTextBox.LoadFile(fileName, RichTextBoxStreamType.PlainText);
        }

        private void richTextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                StringToBold();
                e.Handled = true;
            }

            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveRichEditAsRTF(_pathUserStory);
                e.Handled = true;
            }

            if (e.Control && e.KeyCode == Keys.O)
            {
                LoadStoryDetails();
                e.Handled = true;
            }

            if (e.Control && e.KeyCode == Keys.D)
            {
                StringToRed();
                e.Handled = true;
            }

            if (e.Control && e.KeyCode == Keys.F)
            {
                StringToGreen();
                e.Handled = true;
            }

            if (e.Control && e.KeyCode == Keys.T)
            {
                MarkAsCompleted();  
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

        private void SaveStoryDetails()
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

        private void MarkAsCompleted()
        {            
            if (richTextBox.SelectionFont.Strikeout)
            {
                richTextBox.SelectionColor = Color.Black;
                richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Regular);
            }
            else
            {
                richTextBox.SelectionColor = Color.Wheat;
                richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Strikeout);
            }
        }

        private void StringToBold()
        {
            if (richTextBox.SelectionLength > 0)
            {
                if (richTextBox.SelectionFont.Bold)
                {
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, richTextBox.SelectionFont.Style & ~FontStyle.Bold);
                }
                else
                {
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, richTextBox.SelectionFont.Style | FontStyle.Bold);
                }

                richTextBox.SelectionStart = richTextBox.SelectionStart + richTextBox.SelectionLength;
                richTextBox.SelectionLength = 0;
                richTextBox.SelectionFont = richTextBox.Font;   
            }
            else
            {
                MessageBox.Show("Selecione algum texto primeiro!");
            }
        }

        private void StringToGreen()
        {
            if (richTextBox.SelectionLength > 0)
            {
                richTextBox.SelectionColor = (richTextBox.SelectionColor == Color.Green) ? richTextBox.ForeColor: Color.Green;
            }
            else
            {
                MessageBox.Show("Selecione algum texto primeiro!");
            }
        }

        private void StringToRed()
        {
            if (richTextBox.SelectionLength > 0)
            {
                richTextBox.SelectionColor = (richTextBox.SelectionColor == Color.Red) ? richTextBox.ForeColor : Color.Red;
            }
            else
            {
                MessageBox.Show("Selecione algum texto primeiro!");
            }
        }
    }
}