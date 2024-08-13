using System.Text.RegularExpressions;

namespace Desenvolvimento
{
    public partial class FormFormatarSQL : Form
    {
        public FormFormatarSQL()
        {
            InitializeComponent();
        }

        private static string ApplyCustomIndentation(string sql)
        {
            var indentationRules = new Dictionary<string, int>
            {
                { "SELECT", 1 },
                { "LEFT JOIN", 3 },
                { "INNER JOIN", 2 },
                { "FROM", 3 },
                { "WHERE", 2 },
                { "AND", 4 },
                { "ORDER BY", 2 },
            };

            var lines = sql.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);

            var resultLines = new List<string>();
            bool isBeforeFrom = true;

            foreach (var line in lines)
            {
                string trimmedLine = line.TrimStart();

                if (trimmedLine.StartsWith("FROM", StringComparison.OrdinalIgnoreCase))
                {
                    isBeforeFrom = false;
                }

                if (!isBeforeFrom || !trimmedLine.Contains(","))
                {
                    foreach (var rule in indentationRules)
                    {
                        if (trimmedLine.StartsWith(rule.Key, StringComparison.OrdinalIgnoreCase))
                        {
                            trimmedLine = new string(' ', rule.Value) + trimmedLine;
                            break;
                        }
                    }
                }

                if (isBeforeFrom)
                {
                    var parts = Regex.Split(trimmedLine, @",\s+");

                    if (parts.Length > 1)
                    {
                        resultLines.Add(parts[0] + ",");
                        for (int i = 1; i < parts.Length; i++)
                        {
                            resultLines.Add(new string(' ', 8) + parts[i].TrimStart());
                        }
                    }
                    else
                    {
                        resultLines.Add(new string(' ', 8) + trimmedLine);
                    }
                }
                else
                {
                    resultLines.Add(trimmedLine);
                }
            }

            return string.Join("\r\n", resultLines);
        }

        public static void FormatSQL(RichTextBox richTextBox)
        {
            int selectionStart = richTextBox.SelectionStart;
            int selectionLength = richTextBox.SelectionLength;
         
            string sql = richTextBox.Text;

            string formattedSql = ApplyCustomIndentation(sql.ToUpper());

            richTextBox.Text = formattedSql;

            richTextBox.Select(selectionStart, selectionLength);
        }

        private void buttonFormatar_Click(object sender, EventArgs e)
        {
            FormatSQL(richTextBox);
        }
    }
}