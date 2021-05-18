using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvance.Class2.Homework.Secoundsolution.Interfaces
{
    public interface ITeacher
    {
        //ITeacher : Subject, override PrintUser()  to show subject
        string Subject { get; set; }

        string PrintUser();
    }
}
