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
        private void ShowJournal()
        {

            //инициализация студентов
            InitStudents();

            journalGrid.ColumnCount = 2;
            journalGrid.RowCount = 1;
            journalGrid.RowHeadersVisible = false;


            //отображение таблицы
            DateTime date = dateTimePicker1.Value;
            for (int i = 0; i < 6; i++)
            {
                journalGrid.Columns.Add($"{date.ToShortDateString()}", date.ToShortDateString());
                journalGrid.Columns[journalGrid.ColumnCount - 1].Width = 75;
                date = date.AddDays(1);
            }
            DataGridViewComboBoxCell markBox = new DataGridViewComboBoxCell();
            markBox.Items.AddRange("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Н", "none");


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
                    var tmpCell = (DataGridViewComboBoxCell)markBox.Clone();
                    row.Cells.Add(tmpCell);
                }
                foreach (var mark in item.Marks)
                {
                    if (journalGrid.Columns.Contains(mark.Date.ToShortDateString()))
                    {
                        row.Cells[(mark.Date - dateTimePicker1.Value).Days + 2].Value = mark.Value.ToString();
                    }
                }
                foreach (var miss in item.Misses)
                {
                    if (journalGrid.Columns.Contains(miss.date.ToShortDateString()))
                    {
                        row.Cells[(miss.date - dateTimePicker1.Value).Days + 2].Value = "Н";
                    }
                }
                journalGrid.Rows.Add(row);
            }
        }

        private void updateComboBox()
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
        }

        private void InitStudents()
        {
            List<Student> students = new List<Student>();
            string query = $"Select * From Student Where idGroup = {groupBox.SelectedValue}";
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

        private void sendUpdateBtn_Click(object sender, EventArgs e)
        {
            List<Student.Mark> marks = new List<Student.Mark>();
            List<Student.Miss> misses = new List<Student.Miss>();
            int resUpdMark, resAddMark, resDelMark, resAddSkip, resDelSkip;
            resUpdMark = resAddMark = resDelMark = resAddSkip = resDelSkip = 0;
            for (int i = 0; i < journalGrid.RowCount - 1; i++)
            {
                for (int j = 2; j < journalGrid.ColumnCount; j++)
                {
                    if (journalGrid[j, i].Value != null)
                    {
                        int idStudent = (int)journalGrid.Rows[i].Cells[0].Value;
                        string date = journalGrid.Columns[j].HeaderText;
                        string queryMark = "Select * " +
                            "From Marks " +
                            $"Where idStudent = {idStudent} And Marks.dateMark = @date And idSub = {subjectBox.SelectedValue}";
                        OleDbCommand commandMark = new OleDbCommand(queryMark, _connection);
                        commandMark.Parameters.Add(new OleDbParameter("@data", date));
                        var readerMark = commandMark.ExecuteReader();
                        string querySkip = "Select * " +
                            "From SkipLesson " +
                            $"Where idStudent = {idStudent} And dateSkip = @date And idSub = {subjectBox.SelectedValue}";
                        OleDbCommand commandSkip = new OleDbCommand(querySkip, _connection);
                        var paramDateSkip = new OleDbParameter("@date", date);
                        commandSkip.Parameters.Add(paramDateSkip);
                        var readerSkip = commandSkip.ExecuteReader();
                        if (Char.IsDigit(journalGrid[j, i].Value.ToString()[0]))
                        {
                            string queryCheckMark = "Select * " +
                                "From Marks " +
                                $"Where idStudent = {idStudent} And Marks.dateMark = @date And Marks.valueMark = {journalGrid[j, i].Value} And idSub = {subjectBox.SelectedValue}";
                            OleDbCommand cmdCheckMark = new OleDbCommand(queryCheckMark, _connection);
                            OleDbParameter param = new OleDbParameter("@date", date);
                            cmdCheckMark.Parameters.Add(param);
                            var checker = cmdCheckMark.ExecuteReader();
                            cmdCheckMark.Parameters.Clear();
                            if (checker.HasRows)
                            {
                                continue;
                            }
                            if (readerMark.HasRows)
                            {
                                string query = $"Update Marks " +
                                    $"Set Marks.valueMark = {journalGrid[j, i].Value} " +
                                    $"Where idStudent = { journalGrid.Rows[i].Cells[0].Value } And Marks.dateMark = @date And idSub = { subjectBox.SelectedValue }";
                                OleDbCommand updateCmd = new OleDbCommand(query, _connection);
                                OleDbParameter paramUpdateMark =
                                updateCmd.Parameters.Add(new OleDbParameter("@date", date));
                                resUpdMark += updateCmd.ExecuteNonQuery();
                            }
                            else if (readerSkip.HasRows)
                            {
                                readerSkip.Read();
                                string query = $"Delete From SkipLesson Where SkipLesson.id = {readerSkip["id"]}";
                                OleDbCommand deleteSkip = new OleDbCommand(query, _connection);
                                resDelSkip += deleteSkip.ExecuteNonQuery();
                            }
                            else
                            {
                                string query = $"Insert Into Marks(idStudent, idSub, dateMark, valueMark) " +
                                    $"Values({idStudent}, {subjectBox.SelectedValue}, '{journalGrid.Columns[j].HeaderText}', {journalGrid[j, i].Value})";
                                OleDbCommand addCommand = new OleDbCommand(query, _connection);
                                resAddMark += addCommand.ExecuteNonQuery();
                            }

                        }
                        else if (journalGrid[j, i].Value.ToString() == "Н")
                        {
                            if (readerMark.HasRows)
                            {
                                string query = $"Delete From Marks " +
                                    $"Where idStudent = {idStudent} And Marks.dateMark = @date And idSub = { subjectBox.SelectedValue }";
                                OleDbCommand deleteMarkCmd = new OleDbCommand(query, _connection);
                                deleteMarkCmd.Parameters.Add(new OleDbParameter("@date", date));
                                resDelMark += deleteMarkCmd.ExecuteNonQuery();
                                string addSkipQuery = "Insert Into SkipLesson(idSub, idStudent, dateSkip) " +
                                    $"Values( {subjectBox.SelectedValue}, {idStudent}, '{date}')";
                                OleDbCommand addSkipCmd = new OleDbCommand(addSkipQuery, _connection);
                                resAddSkip += addSkipCmd.ExecuteNonQuery();
                            }
                            else if (readerSkip.HasRows)
                            {
                                continue;
                            }
                            else
                            {
                                string query = $"Insert Into SkipLesson(idStudent, idSub, dateSkip) " +
                                    $"Values({idStudent}, {subjectBox.SelectedValue}, '{date}')";
                                OleDbCommand addCommand = new OleDbCommand(query, _connection);
                                resAddSkip += addCommand.ExecuteNonQuery();
                            }
                        }
                        else if (journalGrid[j, i].Value.ToString() == "none")
                        {
                            if (readerMark.HasRows)
                            {
                                readerMark.Read();
                                string query = $"Delete From Marks Where id = {readerMark["id"]}";
                                OleDbCommand deleteMarkCmd = new OleDbCommand(query, _connection);
                                resDelMark = deleteMarkCmd.ExecuteNonQuery();
                            }
                            if (readerSkip.HasRows)
                            {
                                readerSkip.Read();
                                string query = $"Delete From SkipLesson Where id = {readerSkip["id"]}";
                                OleDbCommand deleteSkipCmd = new OleDbCommand(query, _connection);
                                resDelSkip = deleteSkipCmd.ExecuteNonQuery();
                            }
                        }
                    }

                }
            }
            MessageBox.Show($@"
Обновлено отметок:      {resUpdMark}
Добавлено отметок:      {resAddMark}
Удалено отметок  :      {resDelMark}
Добавлено пропусков:    {resAddSkip}
Удалено пропусков:      {resDelSkip}
", "Статистика");
        }



    }
}