using CSharpAdvance.Class2.Homework.Classes;
using CSharpAdvance.Class2.Homework.Interfaces;
using System;
using System.Collections.Generic;

namespace CSharpAdvance.Class2.Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> bobGrades = new List<int> { 7, 9, 6, 8 };
            List<int> jilGrades = new List<int> { 6, 7, 9, 9 };
            IStudent bob = new Student(4, "Bob", "bob", "bob123", bobGrades);
            IStudent jil = new Student(7, "Jil", "jil", "jil321", jilGrades);
            ITeacher nikola = new Teacher(2, "Nikola", "nik", "nik123", "C#Basic");
            ITeacher trajan = new Teacher(1, "Trajan", "tra", "tra123", "C#Advance");

            Console.WriteLine(bob.PrintUser());
            Console.WriteLine(jil.PrintUser());
            Console.WriteLine("----------------------------------");
            Console.WriteLine(nikola.PrintUser());
            Console.WriteLine(trajan.PrintUser());



            Console.ReadLine();
        }
    }
}
