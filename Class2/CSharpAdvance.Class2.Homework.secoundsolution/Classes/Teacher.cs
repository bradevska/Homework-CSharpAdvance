using CSharpAdvance.Class2.Homework.Secoundsolution.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvance.Class2.Homework.Secoundsolution.Classes
{
    public class Teacher : User, ITeacher
    {
        //Create a class Teacher  that inherits from User and ITeacher

        public Teacher(int id,string name,string username,string password,string subject)
            :base(id,name,username,password)
        {
            Subject = subject;
        }
        public string Subject { get ; set; }

        public string PrintUser()
        {
            return $"{Id}. {Name}, {Username} subject:{Subject}";
        }
    }
}
