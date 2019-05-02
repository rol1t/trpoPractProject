using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace trpoMarkAnalizerProject
{
    public partial class DocForm : Form
    {
        OleDbConnection _con;
        public DocForm(OleDbConnection connection)
        {
            InitializeComponent();
            _con = connection;
            InitCBox();

        }

        private void InitCBox()
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * From [Group]", _con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "nameGroup";
            comboBox1.DataSource = table;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var date = dateTimePicker.Value;
            int idGroup = (int)comboBox1.SelectedValue;
            if (radioButton2.Checked == true)
            {
                Task.Run(() =>
                {
                    // Создаём экземпляр нашего приложения
                    Excel.Application excelApp = new Excel.Application();
                    // Создаём экземпляр рабочий книги Excel
                    Excel.Workbook workBook;
                    // Создаём экземпляр листа Excel
                    Excel.Worksheet workSheet;

                    workBook = excelApp.Workbooks.Add();
                    workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);
                    var students = MainForm.CreateCustomStudentArray(idGroup, date, 30);
                    workSheet.Cells[1, 1] = "Номер";
                    workSheet.Cells[1, 2] = "Имя";
                    workSheet.Columns[2].ColumnWidth = 30;
                    var dateList = new List<DateTime>();

                    for (int i = 3; i < 33; i++)
                    {
                        workSheet.Cells[1, i] = date.Day;
                        workSheet.Columns[i].ColumnWidth = 2;
                        dateList.Add(date);
                        date = date.AddDays(1);
                    }

                    for (int i = 0; i < students.Count; i++)
                    {
                        var student = students[i];
                        workSheet.Cells[i + 2, 1] = i + 1;
                        workSheet.Cells[i + 2, 2] = student.Name;
                        for (int j = 3; j < 33; j++)
                        {
                            var checkDate = from d in student.Misses
                                            where d.date.Day == workSheet.Cells[1, j].Value
                                            select d;
                            if (checkDate.Count() != 0)
                            {
                                workSheet.Cells[i + 2, j] = checkDate.Count();
                            }

                        }
                        var rng = workSheet.Range[$"AG{i + 2}"];
                        rng.Formula = $"=SUM(D{i + 2}:AF{i + 2})";
                        rng.FormulaHidden = false;

                    }
                    workSheet.Range[$"AF{students.Count + 2}"].Value = "Итого";
                    var rngSum = workSheet.Range[$"AG{students.Count + 2}"];
                    rngSum.Formula = $"=SUM(AG2:AG{students.Count + 1})";
                    rngSum.FormulaHidden = false;
                    excelApp.Visible = true;
                    excelApp.UserControl = true;
                });
            }


        }

        private void AvrgMarkBtn_Click(object sender, EventArgs e)
        {
            var date = dateTimePicker.Value;
            int idGroup = (int)comboBox1.SelectedValue;
            if (radioButton2.Checked == true)
            {
                Task.Run(() =>
                {
                    // Создаём экземпляр нашего приложения
                    Excel.Application excelApp = new Excel.Application();
                    // Создаём экземпляр рабочий книги Excel
                    Excel.Workbook workBook;
                    // Создаём экземпляр листа Excel
                    Excel.Worksheet workSheet;

                    workBook = excelApp.Workbooks.Add();
                    workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);
                    var students = MainForm.CreateCustomStudentArray(idGroup, date, 30);
                    string query = $@"SELECT Distinct  Subject.id, nameSub
FROM  ((Subject LEFT JOIN Marks ON Subject.id = Marks.idSub)
Left Join Student On Student.id = Marks.idStudent)
Left Join [Group] On Group.id = Student.IdGroup
Where Group.id = {idGroup} 
;
";
                    //workSheet.Range["A1:NZ1"].Style.Alignment.TextRotation = 90;
                    var command = new OleDbCommand(query, _con);
                    var reader = command.ExecuteReader();
                    Dictionary<int, string> subjectList = new Dictionary<int, string>(); ;
                    while (reader.Read())
                    {
                        subjectList.Add(reader.GetInt32(0), reader.GetString(1));
                    }
                    workSheet.Cells[1, 1] = "Номер";
                    workSheet.Cells[1, 2] = "Имя";
                    workSheet.Columns[2].ColumnWidth = 30;

                    var valuesSub = subjectList.Values;
                    int index = 3;
                    foreach (var item in subjectList)
                    {
                        workSheet.Cells[1, index] = item.Value;
                        workSheet.Columns[index++].ColumnWidth = 15;
                    }
                    if (subjectList.Count != 0)
                    {


                        for (int i = 0; i < students.Count; i++)
                        {
                            var student = students[i];
                            workSheet.Cells[i + 2, 1] = i + 1;
                            workSheet.Cells[i + 2, 2] = student.Name;
                            int j = 3;
                            foreach (var item in subjectList)
                            {
                                var checkDate = (from d in student.Marks
                                                 where d.IdSub == item.Key
                                                 select d.Value);
                                double avrg = checkDate.Count() > 0 ? checkDate.Average() : 0;
                                workSheet.Cells[i + 2, j++] = avrg;

                            }



                            var rng = workSheet.Range[$"AG{i + 2}"];
                            rng.Formula = $"=SUM(D{i + 2}:AF{i + 2})";
                            rng.FormulaHidden = false;

                        }
                    }
                    workSheet.Range[$"AF{students.Count + 2}"].Value = "Итого";
                    var rngSum = workSheet.Range[$"AG{students.Count + 2}"];
                    rngSum.Formula = $"=SUM(AG2:AG{students.Count + 1})";
                    rngSum.FormulaHidden = false;
                    excelApp.Visible = true;
                    excelApp.UserControl = true;

                });
            }
        }

        private void DocForm_Load(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
