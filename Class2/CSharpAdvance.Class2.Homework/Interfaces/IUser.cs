using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvance.Class2.Homework.Interfaces
{
    public interface IUser
    {
        int Id { get; set; }
        string Name { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        void PrintUser()
        {
            Console.WriteLine($"{Name} {Id} {UserName}");
        }
    }
}
