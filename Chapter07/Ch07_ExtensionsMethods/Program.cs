using Ch06_PackLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Ch07_ExtensionsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string email1 = "pamela@test.com";
            string email2 = "ian&text.com";

            WriteLine($"{email1} is a valid e-mail address: {email1.IsValidEmail()}.");
            WriteLine($"{email2} is a valid e-mail address: {email2.IsValidEmail()}.");

            string number = "10";

            WriteLine($"{number} is parsed to {number.ToInt32Extension()}");
            WriteLine($"{number} is parsed and added a value {number.ToInt32ExtensionAddInteger(5)}");

            //Animals

            Animal[] animals = new Animal[3]
            {
                new Animal("Gordi",3),
                new Animal("Puti", 5),
                new Animal("Tristan", 4)
            };

            //Animals animalList = new Animals(animals);

            WriteLine($"The youngest animal is {animals.GetMinVal<Animal>(ani => ani.Age)} years old");
            var aa = animals.MyOwnWhere<Animal>(ani => ani.Name.Substring(0, 1) == "G");
            foreach (var animal in aa)
            {
                WriteLine($"{animal.Name} is {animal.Age} years old");
            }

            // Animals IEnumerable

            Animals animalList = new Animals(animals);

            foreach (Animal a in animalList)
            {
                WriteLine($"{a.Name} is {a.Age} years old");
            }

            //Linq examples
            List<Animal> animalList2 = new List<Animal>();
            animalList2.Add(new Animal("Gordi", 5));
            animalList2.Add(new Animal("Tristan", 15));
            //https://www.codeproject.com/Articles/33769/Basics-of-LINQ-Lamda-Expressions#intro
            var iNames = from i in animalList2 select i.Name;

            foreach (var x in iNames)
            {
                WriteLine($"{x}");
            }

            var iAges = animalList2.Select<Animal, int>(r => r.Age);

            foreach (var x in iAges)
            {
                WriteLine($"{x}");
            }

            ReadKey();
        }
    }
}
