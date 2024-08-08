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
                _pathDocumentacao = _utils.GetIniParam(IniParamsEnum.DiretorioDocumentation);
            }
            catch 
            {
            }
        }
    }
}
