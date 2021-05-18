using CSharpAdvance.Class2.Homework.Secoundsolution.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvance.Class2.Homework.Secoundsolution.Classes
{
    public abstract class User : IUser
    {
        protected User(int id, string name, string username, string password)
        {
            Id = id;
            Name = name;
            Username = username;
            Password = password;
        }

        //Create an abstract  class User and inherits from IUser
        public int Id { get ; set; }
        public string Name { get; set; }
        public string Username { get; set ; }
        public string Password { get ; set ; }

        public void Printuser()
        {
            Console.WriteLine($"{Id}. {Name}, {Username}");
        }
    }
}
