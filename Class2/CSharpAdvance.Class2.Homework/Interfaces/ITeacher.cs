using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvance.Class2.Homework.Interfaces
{
    public interface ITeacher : IUser
    {
        string Subject { get; set; }

        new string PrintUser()
        {
            return Subject;
        }
    }
}
