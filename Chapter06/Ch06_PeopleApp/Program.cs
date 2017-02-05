using Ch06_PackLibrary;
using static System.Console;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06_PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person();
            p1.Name = "Xavi Giménez";
            p1.DateOfBirth = new DateTime(1971, 12, 22);
            p1.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
            //p1.BucketList = (WondersOfTheAncientWorld)18;
            WriteLine($"{p1.Name}'s bucket list is {p1.BucketList}");
            WriteLine($"{p1.Name} was born on {p1.DateOfBirth:dddd, d MMMM yyyy}");
            WriteLine($"{p1.Name} is a {Person.Species}");
            WriteLine($"{p1.Name} was born on {p1.HomePlanet}");
            var p2 = new Person { Name = "Alice Jones", DateOfBirth = new DateTime(1998, 3, 17) };
            WriteLine($"{p2.Name} was born on {p2.DateOfBirth:dddd, d MMMM yyyy}");

            p1.Children.Add(new Person());
            p1.Children.Add(new Person());

            WriteLine($"{p1.Name} has {p1.Children.Count} children.");

            p1.WriteToconsole();
            p1.GetOrigin();
            p1.OptionalParameters();
            p1.OptionalParameters("Jump!", 98.5);
            p1.OptionalParameters(number: 52.7, command: "Hide!");

            p1.OptionalParameters("Poke!", active: false);

            WriteLine(p1.SayHello());
            WriteLine(p1.SayHello("Emily"));

            //BankAccount
            BankAccount.InterestRate = 0.012M;
            var ba1 = new BankAccount();
            ba1.AccountName = "Mrs. Jones";
            ba1.Balance = 2400;
            WriteLine($"{ba1.AccountName} earned {ba1.Balance * BankAccount.InterestRate} interest.");
            var ba2 = new BankAccount();
            ba2.AccountName = "Ms. Gerrier";
            ba2.Balance = 98;
            WriteLine($"{ba2.AccountName} earned {ba2.Balance + BankAccount.InterestRate} interest.");

            // constructors

            var p3 = new Person();
            WriteLine($"{p3.Name} was instantieated at {p3.Instantiated:hh:mm:ss} on {p3.Instantiated:dddd, d MMMM yyyy}");

            var p4 = new Person("Aziz");
            WriteLine($"{p4.Name} was instantieated at {p4.Instantiated:hh:mm:ss} on {p4.Instantiated:dddd, d MMMM yyyy}");


            var max = new Person { Name = "Max", DateOfBirth = new DateTime(1972, 1, 27) };
            WriteLine(max.Origin);
            WriteLine(max.Greeting);
            WriteLine(max.Age);

            max.FavouriteIceCream = "chocolate Fudge";
            WriteLine($"Max's favourite ice-cream flavour is {max.FavouriteIceCream}");
            max.FavouritePrimaryColour = "Blue";
            WriteLine($"Max's favourite primary colour is {max.FavouritePrimaryColour}");


            // Indexes
            max.Children.Add(new Person { Name = "Charlie" });
            max.Children.Add(new Person { Name = "Ella" });
            WriteLine($"Max's first child is {max.Children[0].Name}");
            WriteLine($"Max's secpmd child is {max.Children[1].Name}");
            WriteLine($"Max's first child is {max[0].Name}");
            WriteLine($"Max's second child is {max[1].Name}");

            // Simplifying methods with operators

            var harry = new Person { Name = "Harry" };
            var tom = new Person { Name = "Tom" };
            var baby1 = harry.Procreate(tom);
            var baby2 = harry * tom;
            WriteLine($"{tom.Name} has { tom.Children.Count} children.");
            WriteLine($"{harry.Name} has {harry.Children.Count} children.");

            p1.Shout += P1_Shout;
            p1.Poke();
            p1.Poke();
            p1.Poke();
            p1.Poke();

            Person[] people =
            {
                new Person { Name = "Simon" },
                new Person { Name = "Jenny" },
                new Person { Name = "Adam" },
                new Person { Name = "Richard" }
            };

            Array.Sort(people);
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }

            Array.Sort(people, new PersonalComparer());
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }

            // Managig memory with reference and value
            var dv1 = new DisplacementVector(3, 5);
            var dv2 = new DisplacementVector(-2, 7);
            var dv3 = dv1 + dv2;
            WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");
            ReadKey();
        }

        private static void P1_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
        }
    }
}
