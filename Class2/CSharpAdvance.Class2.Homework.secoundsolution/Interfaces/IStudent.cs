using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvance.Class2.Homework.Secoundsolution.Interfaces
{
    public interface IStudent
    {
        //IStudent:  Grades, override PrintUser()  to show grades

        List<int> Grades { get; set; }

         string PrintUser();
    }
}
