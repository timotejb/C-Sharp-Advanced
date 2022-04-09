using Exercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class Student: User, IStudent
    {
        public Student(int id, string name, string username, string password, List<int> grades) : base(id, name, username, password)
        {
            Grades = grades;
        }

        public List<int> Grades { get; set; }

        public override void PrintUser()
        {
            foreach(int grade in Grades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
