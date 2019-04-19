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
            TeacherShow();
            SubjectShow();
            StudentShow();
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            InitPage();
            ComboBoxAdd();
            ComboBoxAdd2();
            ComboBoxAdd3();
        }

        private void InitPage()
        {
            ShowJournal();  
        }

        public void ComboBoxAdd()
        {
            string query = "SELECT nameGroup, id FROM [Group]";
            OleDbDataAdapter da = new OleDbDataAdapter(query, _connection);
            DataTable ds = new DataTable();
            da.Fill(ds);
            comboBox3.DataSource = ds;
            comboBox3.DisplayMember = "nameGroup";
            comboBox3.ValueMember = "id";
            comboBox3.SelectedIndex = -1;
            comboBox1.DataSource = ds;
            comboBox1.DisplayMember = "nameGroup";
            comboBox1.ValueMember = "id";
            comboBox1.SelectedIndex = -1;
        }

        public void ComboBoxAdd2()
        {
            string query = "SELECT nameSub, id FROM Subject";
            OleDbDataAdapter da = new OleDbDataAdapter(query, _connection);
            DataTable ds = new DataTable();
            da.Fill(ds);
            comboBox2.DataSource = ds;
            comboBox2.DisplayMember = "nameSub";
            comboBox2.ValueMember = "id";
            comboBox2.SelectedIndex = -1;
        }

        public void ComboBoxAdd3()
        {
            string query = "SELECT lastName, id FROM Teacher";
            OleDbDataAdapter da = new OleDbDataAdapter(query, _connection);
            DataTable ds = new DataTable();
            da.Fill(ds);
            comboBox4.DataSource = ds;
            comboBox4.DisplayMember = "lastName";
            comboBox4.ValueMember = "id";
            comboBox4.SelectedIndex = -1;
        }
        public void TeacherShow()
        {
            string query2 = "SELECT Teacher.id, Teacher.lastName, Teacher.firstName, Teacher.sureName, Teacher.dateBirth, Teacher.aducation, Teacher.address, Teacher.phoneNum FROM Teacher";
            OleDbCommand command2 = new OleDbCommand(query2, _connection);
            OleDbDataReader reader2 = command2.ExecuteReader();
            teacherGrid.Rows.Clear();
            while (reader2.Read())
            {
                teacherGrid.Rows.Add(reader2[0].ToString(), reader2[1].ToString(), reader2[2].ToString(), reader2[3].ToString(), reader2[4].ToString(), reader2[5].ToString(), reader2[6].ToString(), reader2[7].ToString());
            }
            reader2.Close();
            aducation_comboBox2.SelectedIndex = -1;
        }

        public void StudentShow()
        {
            string query2 = "SELECT Student.id, Group.nameGroup, Student.lastName, Student.firstName, Student.sureName, Student.address, Student.phoneNum FROM[Group] INNER JOIN Student ON Group.id = Student.idGroup";
            OleDbCommand command2 = new OleDbCommand(query2, _connection);
            OleDbDataReader reader2 = command2.ExecuteReader();
            studentGrid.Rows.Clear();
            while (reader2.Read())
            {
                studentGrid.Rows.Add(reader2[0].ToString(), reader2[1].ToString(), reader2[2].ToString(), reader2[3].ToString(), reader2[4].ToString(), reader2[5].ToString(), reader2[6].ToString());
            }
            reader2.Close();
        }

        public void SubjectShow()
        {
            string query2 = "SELECT Subject.id, lastName, Subject.nameSub FROM Subject Inner Join Teacher On Subject.idTeacher = Teacher.id";
            OleDbCommand command2 = new OleDbCommand(query2, _connection);
            OleDbDataReader reader2 = command2.ExecuteReader();
            subjectGrid.Rows.Clear();
            while (reader2.Read())
            {
                subjectGrid.Rows.Add(reader2[0].ToString(), reader2[1].ToString(), reader2[2].ToString());
            }
            reader2.Close();
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

            journalGrid.ColumnCount = 2;
            journalGrid.RowCount = 1;
    

            //отображение таблицы
            DateTime date = dateTimePicker1.Value;
            for (int i = 0; i < 6; i++)
            {
                journalGrid.Columns.Add($"dateClmn{i}", date.ToShortDateString());
                date = date.AddDays(1);
            }
            DataGridViewComboBoxCell markBox = new DataGridViewComboBoxCell();
            markBox.Items.AddRange(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, "Н", "none");


            foreach (var item in _students)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell idCell = new DataGridViewTextBoxCell();
                idCell.Value = item.Id;
                DataGridViewTextBoxCell nameCell = new DataGridViewTextBoxCell();
                nameCell.Value = item.Name;
                row.Cells.AddRange(idCell, nameCell);
                for (int i = 0; i < 6; i++)
                {
                    
                }
            }


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

        private void button6_Click(object sender, EventArgs e)
        {
            Add_label.Text = "Добавление";
            lastName_textBox3.Text = "";
            firstName_textBox3.Text = "";
            sureName_textBox3.Text = "";
            dateBirth.Text = "";
            aducation_comboBox2.Text = "";
            adress_textBox3.Text = "";
            phoneNumber.Text = "";
            panel1.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SearchInGrid(teacherGrid, textBox2.Text);
            //for (int i = 0; i < teacherGrid.RowCount; i++)
            //{
            //    teacherGrid.Rows[i].Selected = false;
            //    for (int j = 1; j < teacherGrid.ColumnCount; j++)
            //        if (teacherGrid.Rows[i].Cells[j].Value != null)
            //            if (teacherGrid.Rows[i].Cells[j].Value.ToString().Contains(textBox2.Text))
            //            {
            //                teacherGrid.Rows[i].Selected = true;
            //                break;
            //            }
            //}
        }

        public void SearchInGrid(DataGridView grid, string value)
        {
            var selectedRows = grid.SelectedRows;
            for (int i = 0; i < grid.SelectedRows.Count; i++)
            {
                selectedRows[i].Selected = false;
            }
            if (value != "")
            {
                for (int i = 0; i < grid.RowCount; i++)
                {
                    for (int j = 0; j < grid.ColumnCount; j++)
                    {
                        if (grid[j, i].Value != null)
                        {
                            if (grid[j, i].Value.ToString().Contains(value))
                            {
                                grid.Rows[i].Selected = true;
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                selectedRows = grid.SelectedRows;
                for (int i = 0; i < grid.SelectedRows.Count; i++)
                {
                    selectedRows[i].Selected = false;
                }
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Save_button12_Click(object sender, EventArgs e)
        {
            if (Add_label.Text == "Добавление")
            {
                if ((lastName_textBox3.Text == "") || (firstName_textBox3.Text == "") || (sureName_textBox3.Text == "") || (aducation_comboBox2.Text == "") || (adress_textBox3.Text == "") || (phoneNumber.Text == ""))
                {
                    MessageBox.Show("Заполните все поля");
                }
                else
                {
                    if ((Convert.ToDateTime(dateBirth.Text) < Convert.ToDateTime("01.01.1950")) || (Convert.ToDateTime(dateBirth.Text) > Convert.ToDateTime("01.01.1998")))
                    {
                        MessageBox.Show("Укажите дату корректно");
                    }
                    else
                    {
                        int j = teacherGrid.RowCount - 2;
                        int id = Convert.ToInt32(teacherGrid[0, j].Value.ToString());
                        int newi = id + 1;
                        string newid = newi.ToString();
                        string query = $"INSERT INTO Teacher VALUES ('{newid}','{lastName_textBox3.Text}','{firstName_textBox3.Text}','{sureName_textBox3.Text}','{dateBirth.Text}', '{aducation_comboBox2.Text}', '{adress_textBox3.Text}', '{phoneNumber.Text}')";
                        OleDbCommand command = new OleDbCommand(query, _connection);
                        command.ExecuteNonQuery();
                        TeacherShow();
                        panel1.Visible = false;
                    }
                }
            }
            else
            if (Add_label.Text == "Изменение")
            {
                int index = teacherGrid.CurrentRow.Index;
                if (index == teacherGrid.RowCount - 1)
                {
                    MessageBox.Show("Выберите заполненную сторку");
                }
                else
                {
                    int id = Convert.ToInt32(teacherGrid[0, index].Value.ToString());
                    string query = $"UPDATE Teacher SET lastName = '{lastName_textBox3.Text}', firstName = '{firstName_textBox3.Text}', sureName = '{sureName_textBox3.Text}', dateBirth = '{dateBirth.Text}', aducation = '{aducation_comboBox2.Text}', address = '{adress_textBox3.Text}', phoneNum = '{phoneNumber.Text}' WHERE Teacher.id = {id}";
                    OleDbCommand command = new OleDbCommand(query, _connection);
                    command.ExecuteNonQuery();
                    TeacherShow();
                    panel1.Visible = false;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int index = teacherGrid.CurrentRow.Index;
            if (index == teacherGrid.RowCount - 1)
            {
                MessageBox.Show("Выберите заполненную сторку");
            }
            else
            {
                Add_label.Text = "Изменение";
                lastName_textBox3.Text = teacherGrid[1, index].Value.ToString();
                firstName_textBox3.Text = teacherGrid[2, index].Value.ToString();
                sureName_textBox3.Text = teacherGrid[3, index].Value.ToString();
                dateBirth.Text = teacherGrid[4, index].Value.ToString();
                aducation_comboBox2.Text = teacherGrid[5, index].Value.ToString();
                adress_textBox3.Text = teacherGrid[6, index].Value.ToString();
                phoneNumber.Text = teacherGrid[7, index].Value.ToString();
                panel1.Visible = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            int index = teacherGrid.CurrentRow.Index;
            if (index == teacherGrid.RowCount - 1)
            {
                MessageBox.Show("Выберите заполненную сторку");
            }
            else
            {
                int id = Convert.ToInt32(teacherGrid[0, index].Value.ToString());
                string query = $"DELETE FROM Teacher WHERE Teacher.id = {id}";
                OleDbCommand command = new OleDbCommand(query, _connection);
                command.ExecuteNonQuery();
            }
            TeacherShow();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SearchInGrid(teacherGrid, textBox2.Text);
        }

        private void studentControl_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            SearchInGrid(studentGrid, textBox11.Text);
        }

        private void subjectControl_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchInGrid(subjectGrid, textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            int index = subjectGrid.CurrentRow.Index;
            if (index == subjectGrid.RowCount - 1)
            {
                MessageBox.Show("Выберите заполненную сторку");
            }
            else
            {
                int id = Convert.ToInt32(subjectGrid[0, index].Value.ToString());
                string query = $"DELETE FROM Subject WHERE Subject.id = {id}";
                OleDbCommand command = new OleDbCommand(query, _connection);
                command.ExecuteNonQuery();
            }
            SubjectShow();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label11.Text = "Добавление";
            comboBox4.Text = "";
            comboBox2.Text = "";
            panel3.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int index = subjectGrid.CurrentRow.Index;
            if (index == subjectGrid.RowCount - 1)
            {
                MessageBox.Show("Выберите заполненную сторку");
            }
            else
            {
                label11.Text = "Изменение";
                comboBox4.Text = subjectGrid[1, index].Value.ToString();
                comboBox2.Text = subjectGrid[2, index].Value.ToString();               
                panel3.Visible = true;
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (label11.Text == "Добавление")
            {
                if ((comboBox4.Text == "") || (comboBox2.Text == ""))
                {
                    MessageBox.Show("Заполните все поля");
                }
                else
                {
                    int j = subjectGrid.RowCount - 2;
                    int id = Convert.ToInt32(subjectGrid[0, j].Value.ToString());
                    int newi = id + 1;
                    string newid = newi.ToString();
                    string query = $"INSERT INTO Subject(idTeacher, nameSub) VALUES ({comboBox4.SelectedValue},'{comboBox2.Text}')";
                    OleDbCommand command = new OleDbCommand(query, _connection);
                    command.ExecuteNonQuery();
                    SubjectShow();
                    panel3.Visible = false;
                }
            }
            else
           if (label11.Text == "Изменение")
            {
                int index = subjectGrid.CurrentRow.Index;
                if (index == subjectGrid.RowCount - 1)
                {
                    MessageBox.Show("Выберите заполненную сторку");
                }
                else
                {
                    int id = Convert.ToInt32(subjectGrid[0, index].Value.ToString());
                    string query = $"UPDATE Subject SET idTeacher = '{comboBox4.SelectedValue}', nameSub = '{comboBox2.Text}' WHERE Subject.id = {id}";
                    OleDbCommand command = new OleDbCommand(query, _connection);
                    command.ExecuteNonQuery();
                    SubjectShow();
                    panel3.Visible = false;
                }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void studentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < studentGrid.Rows.Count - 1; i++)
                studentGrid.Rows[i].Visible = studentGrid[1, i].Value.ToString() == comboBox1.Text;
            if (comboBox1.Text == "")
            {
                StudentShow();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StudentShow();
            comboBox1.Text = "";
            textBox11.Text = "";
        }

    }
}
