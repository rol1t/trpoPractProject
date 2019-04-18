using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trpoMarkAnalizerProject
{
    public partial class Form1 : Form
    {
        static public OleDbConnection _connection;
        

        public Form1()
        {
            InitializeComponent();
            InitDB();
            InitPage();
        }

        private void InitPage()
        {
            InitJournal();
        }

        private void InitJournal()
        {
            //init group combobox
            var adapter = new OleDbDataAdapter("SELECT * From GroupBox", _connection);
            var table = new DataTable();
            adapter.Fill(table);
            groupBox.ValueMember = "id";
            groupBox.DisplayMember = "nameGroup";
            groupBox.DataSource = table;

            //init subjectBox
            adapter.SelectCommand.CommandText = "Select * From Subject";
            var tableSub = new DataTable();
            adapter.Fill(tableSub);
            subjectBox.ValueMember = "id";
            subjectBox.DisplayMember = "nameSub";
            subjectBox.DataSource = tableSub;
        }

        private void showJournal()
        {
            Dictionary<DateTime, Student> journal = new Dictionary<DateTime, Student>();
        }

        private void InitDB()
        {
            _connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
Data Source=C:\Users\Алексей\source\repos\rol1t\trpoPractProject\trpoMarkAnalizerProject\trpoMarkAnalizerProject\Marks1.accdb;Persist Security Info=True");
            _connection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _connection.Close();
        }

        private void journalPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
