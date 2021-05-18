using CSharpAdvance.Class2.Homework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvance.Class2.Homework.Classes
{
    public class Student : User, IStudent
    {
        public Student(int id, string name, string userName, string password, List<int> grades) : base(id, name, userName, password)
        {
            this.Grades = grades;
        }
        public List<int> Grades { get; set; }

    }
}
