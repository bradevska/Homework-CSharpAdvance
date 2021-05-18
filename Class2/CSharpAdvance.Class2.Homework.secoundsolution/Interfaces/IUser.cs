using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvance.Class2.Homework.Secoundsolution.Interfaces
{
    public interface IUser
    {
        //User : Id, Name, Username, Password, PrintUser() -Prints Id, Name and Username

        int Id{get;set;}
        string Name { get; set; }
        string Username { get; set; }
        string Password { get;set }

        void Printuser();

    }
}
