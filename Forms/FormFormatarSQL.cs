namespace Desenvolvimento
{
    public partial class FormFormatarSQL : Form
    {
        public FormFormatarSQL()
        {
            InitializeComponent();
        }

        private static class Spaces
        {
            public const string Select = "' ";
            public const string Campo = "'        ";
            public const string From = "'   ";
            public const string InnerJoin = "'  ";
            public const string LeftJoin = "'   ";
            public const string Where = "'  ";
            public const string And = "'    ";
            public const string Union = "'  ";
            public const string OrderBy = "'  ";
            public const string GrupoBy = "'  ";
            public const string Default = "'  ";

            public const string Quebra = " ' +";
            public const string Final = " ';";
        }

        private string[] FormatarDelphi(string[] prLines)
        {
            var vFormattedSQL = new List<string>();

            foreach (var vLine in prLines)
            {
                var vTrimmedLine = vLine.Trim().ToUpper();

                switch (vTrimmedLine.Split(' ')[0])
                {
                    case "SELECT":
                        vFormattedSQL.Add(Spaces.Select + vTrimmedLine + Spaces.Quebra);
                        break;
                    case "FROM":
                        vFormattedSQL.Add(Spaces.From + vTrimmedLine + Spaces.Quebra);
                        break;
                    case "INNER":
                        if (vTrimmedLine.StartsWith("INNER JOIN"))
                            vFormattedSQL.Add(Spaces.InnerJoin + vTrimmedLine + Spaces.Quebra);
                        break;
                    case "LEFT":
                        if (vTrimmedLine.StartsWith("LEFT JOIN"))
                            vFormattedSQL.Add(Spaces.LeftJoin + vTrimmedLine + Spaces.Quebra);
                        break;
                    case "WHERE":
                        vFormattedSQL.Add(Spaces.Where + vTrimmedLine + Spaces.Quebra);
                        break;
                    case "AND":
                        vFormattedSQL.Add(Spaces.And + vTrimmedLine + Spaces.Quebra);
                        break;
                    case "UNION":
                        vFormattedSQL.Add(Spaces.Union + vTrimmedLine + Spaces.Quebra);
                        break;
                    case "GROUP":
                        if (vTrimmedLine.StartsWith("GROUP BY"))
                            vFormattedSQL.Add(Spaces.GrupoBy + vTrimmedLine + Spaces.Quebra);
                        break;
                    case "ORDER":
                        if (vTrimmedLine.StartsWith("ORDER BY"))
                            vFormattedSQL.Add(Spaces.OrderBy + vTrimmedLine + Spaces.Quebra);
                        break;
                    default:
                        if (prLines.Last() == vLine)
                            vFormattedSQL.Add(Spaces.Default + vTrimmedLine + Spaces.Quebra);
                        else if (!string.IsNullOrWhiteSpace(vTrimmedLine))
                            vFormattedSQL.Add(Spaces.Campo + vTrimmedLine + Spaces.Final);
                        else
                            vFormattedSQL.Add(string.Empty);
                        break;
                }
            }

            return vFormattedSQL.ToArray();
        }

        private string RemoveFirstAndLastQuotes(string prValue)
        {
            var result = prValue;
            var vFirstQuotePos = result.IndexOf('\'');
            if (vFirstQuotePos >= 0)
                result = result.Remove(vFirstQuotePos, 1);

            var vLastQuotePos = result.LastIndexOf('\'');
            if (vLastQuotePos >= 0)
                result = result.Remove(vLastQuotePos, 1);

            var vPlusPos = result.LastIndexOf('+');
            if (vPlusPos >= 0)
                result = result.Remove(vPlusPos, 1);

            var vSemicolon = result.LastIndexOf(';');
            if (vSemicolon >= 0)
                result = result.Remove(vSemicolon, 1);

            return result;
        }

        private string[] DesformatarDelphi(string[] prLines)
        {
            var vSQLFormat = new List<string>();

            foreach (var vString in prLines)
            {
                vSQLFormat.Add(RemoveFirstAndLastQuotes(vString));
            }

            return vSQLFormat.ToArray();
        }

        private void buttonFormatar_Click(object sender, EventArgs e)
        {
            richTextBox.Lines = DesformatarDelphi(richTextBox.Lines);
            richTextBox.SelectAll();
            Clipboard.SetText(richTextBox.Text);
        }

        private void buttonFormatarDelphi_Click(object sender, EventArgs e)
        {
            richTextBox.Lines = FormatarDelphi(richTextBox.Lines);
            richTextBox.SelectAll();
            Clipboard.SetText(richTextBox.Text);
        }
    }
}