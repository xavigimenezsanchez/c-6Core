using System;
using System.Collections;

namespace Ch06_PackLibrary
{
    public class Animal 
    {
        public Animal(string pname, int page)
        {
            this.name = pname;
            this.age = page;
        }

        private string name;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
            }
        }

    }

    public class Animals : IEnumerable
    {
        private Animal[] _animals;
        public Animals(Animal[] animalArray)
        {
            _animals = new Animal[animalArray.Length];

            for (int i = 0; i < animalArray.Length; i++)
            {
                _animals[i] = animalArray[i];
            }
        }

        // Implementation for the GetEnumerator method
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        public AnimalEnum GetEnumerator()
        {
            return new AnimalEnum(_animals);
        }

    }

    public class AnimalEnum : IEnumerator
    {
        private Animal[] animals;

        int position = -1;

        public AnimalEnum(Animal[] list)
        {
            animals = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < animals.Length);
        }
        public void Reset()
        {
            position = -1;
        }

        public Animal Current
        {
            get
            {
                try
                {
                    return animals[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        //internal Animal[] Animals { get => animals; set => animals = value; }
    }
}
