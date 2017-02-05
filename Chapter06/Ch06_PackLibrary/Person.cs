using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06_PackLibrary
{
    public partial class Person : Object
    {
        public override string ToString()
        {
            return $"{Name} is a {base.ToString()}";
        }
        // fields
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();

        // constants
        public const string Species = "Homo Sapien";

        // read-only fields
        public readonly string HomePlanet = "Earth";

        public DateTime Instantiated;

        // constructors
        public Person()
        {
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName)
        {
            Name = initialName;
            Instantiated = DateTime.Now;
        }

        // methods
        public virtual void WriteToconsole()
        {
            WriteLine($"{Name} was born on {DateOfBirth:dddd, d MMMM yyyy}");
        }

        public String GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}";
        }

        public string SayHello()
        {
            return $"{Name} says 'Hello!'";
        }

        public string SayHello(string name)
        {
            return $"{Name} says 'Hello {name}!'";
        }

        public void OptionalParameters(string command = "Run!", double number = 0.0, bool active = true)
        {
            WriteLine($"command is {command}, number is {number}, active is {active}");
        }


    }
}
