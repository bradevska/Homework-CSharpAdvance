using System;

namespace CSharpAdvance.Class3.Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create 3 Dog objects, call validate  on them to see if they are okay,
            //add them in the List of Dogs and call PrintAll()

            Dog Lusi = new Dog() { Id = -5, Name = "Lusi", Color = "Black" };//za proba staveno -5,ne se pecati
            Dog Dzeki = new Dog() { Id = 3, Name = "Dzeki", Color = "Brown" };
            Dog Sharko = new Dog() { Id = 2, Name = "Sharko", Color = "White" };


            if (Dog.Validate(Lusi))
            {
                DogShelter.ListOfDogs.Add(Lusi);
            }
            if (Dog.Validate(Dzeki))
            {
                DogShelter.ListOfDogs.Add(Dzeki);
            }
            if (Dog.Validate(Sharko))
            {
                DogShelter.ListOfDogs.Add(Sharko);
            }

            DogShelter.PrintAll();
           

            Console.ReadLine();


        }
    }
}
