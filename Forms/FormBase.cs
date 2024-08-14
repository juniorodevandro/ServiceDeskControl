using Desenvolvimento.Enums;
using Desenvolvimento.Shared;
using SharpSvn;

namespace Desenvolvimento.Forms
{
    public partial class FormBase : Form
    {
        protected uTils _utils = new();
        protected readonly SvnClient _client = new();
        protected string _snvBranch = string.Empty;
        protected string _snvBranchReview = string.Empty;
        protected string _snvTrunk = string.Empty;
        protected string _defaultVersion = string.Empty;
        protected string _pathFont = string.Empty;
        protected string _pathDocumentacao = string.Empty;

        public FormBase()
        {
            InitializeComponent();

            LoadIniParams();
        }

        protected void FormBase_Load(object sender, EventArgs e)
        {
            LoadIniParams();
        }

        protected void LoadIniParams()
        {
            try
            {
                _snvBranch = _utils.GetIniParam(IniParamsEnum.SVNBranch);
                _snvBranchReview = _utils.GetIniParam(IniParamsEnum.SVNBranchReview);
                _snvTrunk = _utils.GetIniParam(IniParamsEnum.SVNTrunk);
                _defaultVersion = _utils.GetIniParam(IniParamsEnum.DefaultVersion);
                _pathFont = _utils.GetIniParam(IniParamsEnum.DiretorioFont);
                _pathDocumentacao = _utils.GetIniParam(IniParamsEnum.DiretorioDocumentacao);
            }
            catch 
            {
            }
        }

        protected void StringToBold(RichTextBox richText)
        {         
            if (richText.SelectionFont.Bold)
            {
                richText.SelectionFont = new Font(richText.SelectionFont, richText.SelectionFont.Style & ~FontStyle.Bold);
            }
            else
            {
                richText.SelectionFont = new Font(richText.SelectionFont, richText.SelectionFont.Style | FontStyle.Bold);
            }
        }

        protected void StringToGreen(RichTextBox richText)
        {
            if (richText.SelectionColor == Color.Green)
            {
                richText.SelectionColor = richText.ForeColor;
            }
            else
            {
                richText.SelectionColor = Color.Green;
            }
        }

        protected void StringToRed(RichTextBox richText)
        {
            if (richText.SelectionColor == Color.Red)
            {
                richText.SelectionColor = richText.ForeColor;
            }
            else
            {
                richText.SelectionColor = Color.Red;
            }          
        }

        protected void MarkAsCompleted(RichTextBox richText)
        {
            if (richText.SelectionLength > 0)
            {
                if (richText.SelectionFont.Strikeout)
                {
                    richText.SelectionColor = Color.Black;
                    richText.SelectionFont = new Font(richText.Font, FontStyle.Regular);
                }
                else
                {
                    richText.SelectionColor = Color.Wheat;
                    richText.SelectionFont = new Font(richText.Font, FontStyle.Strikeout);
                }
            }
        }

        protected void OpenRichEditAsRTF(RichTextBox richText, string fileName)
        {
            richText.LoadFile(fileName, RichTextBoxStreamType.RichText);
        }

        protected void SaveRichEditAsRTF(RichTextBox richText, string fileName)
        {
            richText.SaveFile(fileName, RichTextBoxStreamType.RichText);
        }

        protected void SaveFile(RichTextBox richText)
        {
            using (SaveFileDialog? saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = _pathDocumentacao;
                saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|Text Files (*.txt)|*.txt";
                saveFileDialog.DefaultExt = "rtf";
                saveFileDialog.FilterIndex = 1;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveRichEditAsRTF(richText, saveFileDialog.FileName);                 
                }
            }
        }
    }
}
