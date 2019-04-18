using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace trpoMarkAnalizerProject
{
    internal class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Miss> Misses { get; set; }
        public List<Mark> Marks { get; set; }

        public class Mark
        {
            public DateTime Date { get; set; }
            public int IdSub { get; set; }
            public int Value
            {
                get => value;
                set
                {
                    if (value > 0 && value <= 10)
                    {
                        this.value = value;
                    }
                    else
                    {
                        throw new Exception($"Число {value} не входит в диапозон отметок");
                    }
                }
            }

            private int value;
        }
        public class Miss
        {
            private int hour;
            public int IdSub { get; set; }
            public int Hour { get => hour; set => hour = value; }

            public DateTime date { get; set; }
        }

        

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
            Misses = new List<Miss>();
            Marks = new List<Mark>();
        }

        public void fillMarkMiss(DateTime date, int idSub)
        {
            //fill Marks in array
            var commandMark = new OleDbCommand($@"Selct *
From Marks Inner Join Student
Where {idSub} = idSub And date >= '{date.ToShortDateString()}' And date <= '{date.AddDays(7).ToShortDateString()}'", 
Form1._connection);
            var adapter = new OleDbDataAdapter(commandMark);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);

        }
    }
}