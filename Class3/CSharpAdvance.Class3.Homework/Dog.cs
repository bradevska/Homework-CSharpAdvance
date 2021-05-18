using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvance.Class3.Homework
{
    public class Dog
    {

        //Create a class called Dog that has:
        //▹Id, Name, Color, Bark() -Prints “Bark Bark”
        //▹A static method  Validate() -Checks if dog has all 3 properties, if Id is not less than 0 and Name is 2 characters or longer

        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public Dog()
        {

        }

        public void Bark()
        {
            Console.WriteLine("Bark,Bark");
        }

        public static bool Validate(Dog dog)
        {
            if (dog.Id >= 0 && dog.Name.Length > 2)
            {
                return true;
            }
            return false;
        } 
        


    }
}
