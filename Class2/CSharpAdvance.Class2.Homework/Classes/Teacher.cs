using CSharpAdvance.Class2.Homework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvance.Class2.Homework.Classes
{
    public class Teacher : User, ITeacher
    {
        public Teacher(int id, string name, string userName, string password, string subject) : base(id, name, userName, password)
        {
            this.Subject = subject;
        }
        public string Subject { get; set; }

        public string Printuser()
        {
            return Subject;
        }
    }
}
