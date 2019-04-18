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
        private List<Student> _students;

        public Form1()
        {
            InitializeComponent();
            InitDB();
            _students = new List<Student>();
            InitPage();
        }

        private void InitPage()
        {
            InitJournal();
        }

        private void InitJournal()
        {
            //init group combobox
            var adapter = new OleDbDataAdapter("SELECT Group.id, Group.nameGroup FROM[Group]; ", _connection);
            var table = new DataTable();
            adapter.Fill(table);
            groupBox.ValueMember = "id";
            groupBox.DisplayMember = "nameGroup";
            groupBox.DataSource = table;

            //init subjectBox
            adapter.SelectCommand.CommandText = "Select * From Subject";
            var tableSub = new DataTable();
            adapter.Fill(tableSub);

            subjectBox.DisplayMember = "nameSub";
            subjectBox.DataSource = tableSub;
            subjectBox.ValueMember = "id";

            //инициализация студентов
            InitStudents();

        }

        private void InitStudents()
        {
            List<Student> students = new List<Student>();
            string query = $"Select * From Student Where idGroup = {groupBox.ValueMember}";
            OleDbCommand command = new OleDbCommand(query, _connection);
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string name = reader["lastName"].ToString() + reader["firstName"].ToString();
                    Student tmp = new Student(id, name);
                    students.Add(tmp);
                }
            }

            for (int i = 0; i < students.Count; i++)
            {
                students[i].fillMarkMiss(dateTimePicker1.Value, (int)subjectBox.SelectedValue);
            }
            _students = students;
        }

        private void showJournal()
        {
            List<Student> students = new List<Student>();
            string query = @"Select  
From Mark Inner Join Student On Student.id = Mark.idStudent";

        }

        private void InitDB()
        {
            _connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
Data Source=Marks1.accdb;Persist Security Info=True");
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

        private void journalPage_Click(object sender, EventArgs e)
        {
            Control.SelectedIndex = 0;
        }

        private void studentPage_Click(object sender, EventArgs e)
        {
            Control.SelectedIndex = 1;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
          
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void subjectBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
