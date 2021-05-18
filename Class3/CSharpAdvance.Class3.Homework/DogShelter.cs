using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvance.Class3.Homework
{
    public static class DogShelter
    {
        //Create a static class called DogShelter  that has:
        //▹List of Dogs
        //▹PrintAll() -prints all dogs from List of Dogs

        public static List<Dog> ListOfDogs = new List<Dog>
        {

        };

        public static void PrintAll()
        {
            foreach(Dog dog in ListOfDogs)
            {
                Console.WriteLine($"Dog Id:{dog.Id}; Dog Name:{dog.Name}; Dog Color:{dog.Color}");
            }
        }


    };
}