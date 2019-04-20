using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace trpoMarkAnalizerProject
{
    public class Student
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

        public void fillMarkMiss(DateTime date, int idSub = -1, int dateRange = 6)
        {
            //fill Marks in array
            Marks.Clear();
            Misses.Clear();
            string query;
            if (idSub != -1)
            {
                query = $@"Select *
From Marks Inner Join Student On Student.id = Marks.idStudent
Where {idSub} = idSub And dateMark >= @dateFrom
And dateMark <= @dateTo And Student.id = {Id}";
            }
            else
            {
                query = query = $@"Select *
From Marks Inner Join Student On Student.id = Marks.idStudent
Where dateMark >= @dateFrom
And dateMark <= @dateTo And Student.id = {Id}";
            }
            var commandMark = new OleDbCommand(query, Form1._connection);
            var paramDateFrom = new OleDbParameter("@dateFrom", date.ToShortDateString()) ;
            var paramDateTo = new OleDbParameter("@dateTo", date.AddDays(dateRange).ToShortDateString());
            commandMark.Parameters.Add(paramDateFrom);
            commandMark.Parameters.Add(paramDateTo);
            var reader = commandMark.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Mark tmpMark = new Mark();
                    tmpMark.Date = (DateTime)reader["dateMark"];
                    tmpMark.IdSub = (int)reader["idSub"];
                    tmpMark.Value = (int)reader["valueMark"];
                    Marks.Add(tmpMark);
                }
            }
            commandMark.Parameters.Clear();

            //fill miss i array
            if (idSub != -1)
            {
                query = $@"Select * 
From SkipLesson Inner Join Student On Student.id = SkipLesson.idStudent
Where {idSub} = idSub And dateSkip >= @dateFrom
And dateSkip <= @dateTo And Student.id = {Id}";
            }
            else
            {
                query = $@"Select * 
From SkipLesson Inner Join Student On Student.id = SkipLesson.idStudent
Where dateSkip >= @dateFrom
And dateSkip <= @dateTo And Student.id = {Id}";
            }
            var commandMiss = new OleDbCommand(query, Form1._connection);
            var paramFrom = new OleDbParameter();
            var paramTo = new OleDbParameter();
            commandMiss.Parameters.Add(paramDateFrom);
            commandMiss.Parameters.Add(paramDateTo);
            reader = commandMiss.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Miss tmpMiss = new Miss();
                    tmpMiss.date = (DateTime)reader["dateSkip"];
                    tmpMiss.Hour = (int)reader["hours"];
                    tmpMiss.IdSub = (int)reader["idSub"];
                    Misses.Add(tmpMiss);
                }
            }
        }
    }
}