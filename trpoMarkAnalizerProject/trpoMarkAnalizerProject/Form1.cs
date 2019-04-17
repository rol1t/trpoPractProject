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
        }

        private void InitDB()
        {
            _connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Marks1.accdb;Persist Security Info=True");
            _connection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Привет, Алексей!!");
        }
    }
}
