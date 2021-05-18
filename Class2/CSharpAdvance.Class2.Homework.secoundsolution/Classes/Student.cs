using CSharpAdvance.Class2.Homework.Secoundsolution.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvance.Class2.Homework.Secoundsolution.Classes
{
    public class Student : User, IStudent
    {
        //Create a class Student  that inherits from User and IStudent

        public Student(int id,string name,string username,string password,List<int> grades)
            : base(id, name, username, password)
        {
            Grades = grades;
        }
        public List<int> Grades { get; set ; }

        public string PrintUser()
        {
            Console.WriteLine($"{Id}.{Name},{Username} are the grades: ");
            foreach(int grades in Grades)
            {
                Console.Write(grades + " ,");
            }
            return string.Empty;
        }
    }
}
