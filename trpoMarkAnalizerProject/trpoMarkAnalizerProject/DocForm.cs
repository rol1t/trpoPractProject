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
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

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
            int idGroup =  (int)comboBox1.SelectedValue;
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
                    excelApp.Visible = true;
                    excelApp.UserControl = true;
                });
            }
            

        }

        private void AvrgMarkBtn_Click(object sender, EventArgs e)
        {

        }

        private void DocForm_Load(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
