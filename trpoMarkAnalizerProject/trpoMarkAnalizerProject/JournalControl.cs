using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace trpoMarkAnalizerProject
{
    public partial class JournalControl : UserControl
    {
        OleDbConnection _connection = Form1._connection;

        public JournalControl()
        {
            InitializeComponent();
            InitComboBox();
            InitJournal();
        }

        private void InitComboBox()
        {

            //init group
            string query = "Select id, nameGroup From Group";
            var command = new OleDbCommand(query, _connection);
            var adapter = new OleDbDataAdapter(command);
            var groupTable = new DataTable();
            adapter.Fill(groupTable);
            groupBox.ValueMember = "id";
            groupBox.DisplayMember = "nameGroup";
            groupBox.DataSource = groupTable;

            //init Subject
            query = "Select id, nameSub From Subject";
            command = new OleDbCommand(query, _connection);
            adapter.SelectCommand = command;
            var subjectTable = new DataTable();
            adapter.Fill(subjectTable);
        }

        private void InitJournal()
        {
            
        }

        private void JournalControl_Load(object sender, EventArgs e)
        {

        }
    }
}
