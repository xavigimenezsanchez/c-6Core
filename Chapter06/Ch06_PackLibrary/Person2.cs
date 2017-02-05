using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06_PackLibrary
{
    public partial class Person : IComparable<Person>
    {
        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }

        // two properties defined using C# 6 lambda expression syntax

        public string Greeting => $"{Name} says 'Hello!'";

        public int Age => (int)(DateTime.Today.Subtract(DateOfBirth).TotalDays / 365.25);

        public string FavouriteIceCream { get; set; } // auto-syntax
        private string favouritePrimaryColour;
        public string FavouritePrimaryColour
        {
            get
            {
                return favouritePrimaryColour;
            }
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favouritePrimaryColour = value;
                        break;
                    default:
                        throw new ArgumentException($"{value} is not a primary colour. choose from: red, green, blue.");
                }
            }
        }

        // indexers

        public Person this[int index]
        {
            get
            {
                return Children[index];
            }
            set
            {
                Children[index] = value;
            }
        }

        // Simplifying methods with operators
        public Person Procreate(Person partner)
        {
            var baby = new Person("Baby");
            Children.Add(baby);
            partner.Children.Add(baby);
            return baby;
        }

        public static Person operator *(Person p1, Person p2)
        {
            return p1.Procreate(p2);
        }

        // events
        public event EventHandler Shout;
        public int AngerLevel;
        public void Poke()
        {
            AngerLevel++;
            if (AngerLevel >= 3)
            {
                //if (Shout != null)
                //{
                //    Shout(this, EventArgs.Empty);
                //}
                Shout?.Invoke(this, EventArgs.Empty);
            }
        }

        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
