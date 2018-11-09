using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSISTools
{
    public partial class SqlPreviewForm : Form
    {
        public SqlPreviewForm()
        {
            InitializeComponent();
        }

        public string SqlStatementSource { get; set; }
        public string SaveFileName { get; set; }

        private void SqlPreviewForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = this.SqlStatementSource;

            foreach(string key in GetTsqlReservedKeywords())
            {
                ColorizeText(0, key, Color.Blue);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.richTextBox1.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "Sql Script (*.sql)|*.sql";
            file.FileName = SaveFileName;

            if (file.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(file.FileName, this.SqlStatementSource);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ColorizeText(int startIndex, string text, Color color)
        {
            int resultIndex = this.richTextBox1.Find(text, startIndex, RichTextBoxFinds.WholeWord);

            if (resultIndex != -1)
            {
                this.richTextBox1.SelectionColor = color;
                ColorizeText(resultIndex + 1, text, color);
            }
                
        }

        private List<string> GetTsqlReservedKeywords()
        {
            List<string> result = new List<string>();
            result.Add("ADD");
            result.Add("EXTERNAL");
            result.Add("PROCEDURE");
            result.Add("ALL");
            result.Add("FETCH");
            result.Add("PUBLIC");
            result.Add("ALTER");
            result.Add("FILE");
            result.Add("RAISERROR");
            result.Add("AND");
            result.Add("FILLFACTOR");
            result.Add("READ");
            result.Add("ANY");
            result.Add("FOR");
            result.Add("READTEXT");
            result.Add("AS");
            result.Add("FOREIGN");
            result.Add("RECONFIGURE");
            result.Add("ASC");
            result.Add("FREETEXT");
            result.Add("REFERENCES");
            result.Add("AUTHORIZATION");
            result.Add("FREETEXTTABLE");
            result.Add("REPLICATION");
            result.Add("BACKUP");
            result.Add("FROM");
            result.Add("RESTORE");
            result.Add("BEGIN");
            result.Add("FULL");
            result.Add("RESTRICT");
            result.Add("BETWEEN");
            result.Add("FUNCTION");
            result.Add("RETURN");
            result.Add("BREAK");
            result.Add("GOTO");
            result.Add("REVERT");
            result.Add("BROWSE");
            result.Add("GRANT");
            result.Add("REVOKE");
            result.Add("BULK");
            result.Add("GROUP");
            result.Add("RIGHT");
            result.Add("BY");
            result.Add("HAVING");
            result.Add("ROLLBACK");
            result.Add("CASCADE");
            result.Add("HOLDLOCK");
            result.Add("ROWCOUNT");
            result.Add("CASE");
            result.Add("IDENTITY");
            result.Add("ROWGUIDCOL");
            result.Add("CHECK");
            result.Add("IDENTITY_INSERT");
            result.Add("RULE");
            result.Add("CHECKPOINT");
            result.Add("IDENTITYCOL");
            result.Add("SAVE");
            result.Add("CLOSE");
            result.Add("IF");
            result.Add("SCHEMA");
            result.Add("CLUSTERED");
            result.Add("IN");
            result.Add("SECURITYAUDIT");
            result.Add("COALESCE");
            result.Add("INDEX");
            result.Add("SELECT");
            result.Add("COLLATE");
            result.Add("INNER");
            result.Add("SEMANTICKEYPHRASETABLE");
            result.Add("COLUMN");
            result.Add("INSERT");
            result.Add("SEMANTICSIMILARITYDETAILSTABLE");
            result.Add("COMMIT");
            result.Add("INTERSECT");
            result.Add("SEMANTICSIMILARITYTABLE");
            result.Add("COMPUTE");
            result.Add("INTO");
            result.Add("SESSION_USER");
            result.Add("CONSTRAINT");
            result.Add("IS");
            result.Add("SET");
            result.Add("CONTAINS");
            result.Add("JOIN");
            result.Add("SETUSER");
            result.Add("CONTAINSTABLE");
            result.Add("KEY");
            result.Add("SHUTDOWN");
            result.Add("CONTINUE");
            result.Add("KILL");
            result.Add("SOME");
            result.Add("CONVERT");
            result.Add("LEFT");
            result.Add("STATISTICS");
            result.Add("CREATE");
            result.Add("LIKE");
            result.Add("SYSTEM_USER");
            result.Add("CROSS");
            result.Add("LINENO");
            result.Add("TABLE");
            result.Add("CURRENT");
            result.Add("LOAD");
            result.Add("TABLESAMPLE");
            result.Add("CURRENT_DATE");
            result.Add("MERGE");
            result.Add("TEXTSIZE");
            result.Add("CURRENT_TIME");
            result.Add("NATIONAL");
            result.Add("THEN");
            result.Add("CURRENT_TIMESTAMP");
            result.Add("NOCHECK");
            result.Add("TO");
            result.Add("CURRENT_USER");
            result.Add("NONCLUSTERED");
            result.Add("TOP");
            result.Add("CURSOR");
            result.Add("NOT");
            result.Add("TRAN");
            result.Add("DATABASE");
            result.Add("NULL");
            result.Add("TRANSACTION");
            result.Add("DBCC");
            result.Add("NULLIF");
            result.Add("TRIGGER");
            result.Add("DEALLOCATE");
            result.Add("OF");
            result.Add("TRUNCATE");
            result.Add("DECLARE");
            result.Add("OFF");
            result.Add("TRY_CONVERT");
            result.Add("DEFAULT");
            result.Add("OFFSETS");
            result.Add("TSEQUAL");
            result.Add("DELETE");
            result.Add("ON");
            result.Add("UNION");
            result.Add("DENY");
            result.Add("OPEN");
            result.Add("UNIQUE");
            result.Add("DESC");
            result.Add("OPENDATASOURCE");
            result.Add("UNPIVOT");
            result.Add("DISK");
            result.Add("OPENQUERY");
            result.Add("UPDATE");
            result.Add("DISTINCT");
            result.Add("OPENROWSET");
            result.Add("UPDATETEXT");
            result.Add("DISTRIBUTED");
            result.Add("OPENXML");
            result.Add("USE");
            result.Add("DOUBLE");
            result.Add("OPTION");
            result.Add("USER");
            result.Add("DROP");
            result.Add("OR");
            result.Add("VALUES");
            result.Add("DUMP");
            result.Add("ORDER");
            result.Add("VARYING");
            result.Add("ELSE");
            result.Add("OUTER");
            result.Add("VIEW");
            result.Add("END");
            result.Add("OVER");
            result.Add("WAITFOR");
            result.Add("ERRLVL");
            result.Add("PERCENT");
            result.Add("WHEN");
            result.Add("ESCAPE");
            result.Add("PIVOT");
            result.Add("WHERE");
            result.Add("EXCEPT");
            result.Add("PLAN");
            result.Add("WHILE");
            result.Add("EXEC");
            result.Add("PRECISION");
            result.Add("WITH");
            result.Add("EXECUTE");
            result.Add("PRIMARY");
            result.Add("WITHIN GROUP");
            result.Add("EXISTS");
            result.Add("PRINT");
            result.Add("WRITETEXT");
            result.Add("EXIT");
            result.Add("PROC");
            result.Add("GO");
            return result;
        }
    }
}
