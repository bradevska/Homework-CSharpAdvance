using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvance.Class2.Homework.Interfaces
{
        public interface IStudent : IUser
        {
            List<int> Grades { get; set; }

        new string PrintUser()
            {
                Console.WriteLine($"{Name} grades are : ");
                foreach (int grade in Grades)
                {
                    Console.Write(grade + " ,");
                }
                return string.Empty;
            }

        }
}
