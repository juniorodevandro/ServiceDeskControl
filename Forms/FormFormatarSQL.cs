using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Desenvolvimento
{
    public partial class FormFormatarSQL : Form
    {
        private const string sSelect = "SELECT";
        private const string sCampo = "       ";
        private const string sFrom = "FROM";
        private const string sInnerJoin = "INNER JOIN";
        private const string sLeftJoin = "LEFT JOIN";
        private const string sWhere = "WHERE";
        private const string sAnd = "AND";
        private const string sUnion = "UNION";
        private const string sOrderBy = "ORDER BY";
        private const string sGrupoBy = "GROUP BY";

        private const string sFromExists = "                      ";
        private const string sInnerJoinExists = "                     ";
        private const string sLeftJoinExists = "                      ";
        private const string sWhereExists = "                     ";
        private const string sAndExists = "                       ";

        private const string sFromNotExists = "                      ";
        private const string sInnerJoinNotExists = "                     ";
        private const string sLeftJoinNotExists = "                      ";
        private const string sWhereNotExists = "                     ";
        private const string sAndNotExists = "                       ";

        private const string sQuebra = " ' +";
        private const string sFinal = " '";

        public FormFormatarSQL()
        {
            InitializeComponent();
        }


        private void btnFormatClick(object sender, EventArgs e)
        {

        }

        private string DesformatarDelphi(string prValue)
        {
            string[] lines = prValue.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();

            foreach (string line in lines)
            {
                result.AppendLine(RemoveFirstAndLastQuotes(line));
            }

            return result.ToString();
        }

        private string FormatarDelphi(string prValue)
        {
            string[] lines = prValue.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder formattedSQL = new StringBuilder();

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].Trim().ToUpper();

                if (line.StartsWith(sSelect))
                    formattedSQL.AppendLine("'" + sSelect + " " + line.Substring(sSelect.Length) + sQuebra);
                else if (line.StartsWith(sFrom))
                    formattedSQL.AppendLine("'" + sFrom + " " + line.Substring(sFrom.Length) + sQuebra);
                else if (line.StartsWith(sInnerJoin))
                    formattedSQL.AppendLine("'" + sInnerJoin + " " + line.Substring(sInnerJoin.Length) + sQuebra);
                else if (line.StartsWith(sLeftJoin))
                    formattedSQL.AppendLine("'" + sLeftJoin + " " + line.Substring(sLeftJoin.Length) + sQuebra);
                else if (line.StartsWith(sWhere))
                    formattedSQL.AppendLine("'" + sWhere + " " + line.Substring(sWhere.Length) + sQuebra);
                else if (line.StartsWith(sAnd))
                    formattedSQL.AppendLine("'" + sAnd + " " + line.Substring(sAnd.Length) + sQuebra);
                else if (line.StartsWith(sUnion))
                    formattedSQL.AppendLine("'" + sUnion + " " + line.Substring(sUnion.Length) + sQuebra);
                else if (line.StartsWith(sGrupoBy))
                    formattedSQL.AppendLine("'" + sGrupoBy + " " + line.Substring(sGrupoBy.Length) + sQuebra);
                else if (line.StartsWith(sOrderBy))
                    formattedSQL.AppendLine("'" + sOrderBy + " " + line.Substring(sOrderBy.Length) + sQuebra);
                else if (i == lines.Length - 1)
                    formattedSQL.AppendLine("'" + sCampo + line + sQuebra);
                else if (!string.IsNullOrEmpty(line))
                    formattedSQL.AppendLine("'" + sCampo + line + sFinal);
                else
                    formattedSQL.AppendLine("");
            }

            return formattedSQL.ToString();
        }

        private string RemoveFirstAndLastQuotes(string prValue)
        {
            string result = prValue;
            int firstQuotePos = result.IndexOf("'");
            if (firstQuotePos >= 0)
                result = result.Remove(firstQuotePos, 1);

            int lastQuotePos = result.LastIndexOf("'");
            if (lastQuotePos >= 0)
                result = result.Remove(lastQuotePos, 1);

            int plusPos = result.LastIndexOf("+");
            if (plusPos >= 0)
                result = result.Remove(plusPos, 1);

            return result;
        }

        private string FormatarSQL(string SQL)
        {
            string SQLFormatado = "";
            int Indentacao = 0;
            bool EmSubquery = false;

            for (int I = 0; I < SQL.Length; I++)
            {
                switch (SQL[I])
                {
                    case '(':
                        if (SQL.Substring(I, 6).ToUpper().StartsWith("SELECT"))
                            EmSubquery = true;
                        SQLFormatado += SQL[I];
                        if (EmSubquery)
                            Indentacao++;
                        break;
                    case ')':
                        if (EmSubquery)
                        {
                            Indentacao--;
                            EmSubquery = false;
                        }
                        SQLFormatado += SQL[I];
                        break;
                    case ',':
                        SQLFormatado += SQL[I] + "\r\n" + new string(' ', Indentacao * 4);
                        break;
                    case '\r':
                    case '\n':
                        SQLFormatado += SQL[I];
                        if (I < SQL.Length - 1)
                        {
                            if (SQL[I + 1] != ' ')
                                SQLFormatado += new string(' ', Indentacao * 4);
                        }
                        break;
                    default:
                        SQLFormatado += SQL[I];
                        break;
                }
            }

            return SQLFormatado;
        }

        private void buttonFormatar_Click(object sender, EventArgs e)
        {
            textBox.Text = FormatarDelphi(textBox.Text);
        }
    }
}