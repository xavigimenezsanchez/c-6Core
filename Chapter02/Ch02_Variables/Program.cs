using static System.Console;

namespace Ch02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //int population = 66000000;
            //double weight = 1.88; // in kilograms
            //decimal price = 4.99M; //int pounds sterling
            //string fruit = "Apples"; // strings use double-quotes
            //char letter = 'Z'; // charas use single-quotes


            var population = 66000000;
            var weight = 1.88; // in kilograms
            var price = 4.99M; // in pounds sterling
            var fruit = "Apples"; // strings use double-quotes
            var letter = 'Z'; // chars use single-quotes
            var happy = true;


            //int defaultValueOfInt = default(int); // 0

            int ICannotBeNull = 4;
            ICannotBeNull = default(int); // 0
            int? ICouldBeNull = null;
            int result1 = ICouldBeNull.GetValueOrDefault(); // 0
            ICouldBeNull = 4;
            int result2 = ICouldBeNull.GetValueOrDefault(); // 4 

            // declaring the size of the array
            string[] names = new string[4];
            // storing items at index positions
            names[0] = "Kate";
            names[1] = "Jack";
            names[2] = "Rebecca";
            names[3] = "Tom";
            for (int i = 0; i < names.Length; i++)
            {
                WriteLine(names[i]); // read the item at this index
            }

            Write($"The population of the UK IS {population}. ");
            WriteLine($"The population of the UK is {population:N0}.");
            WriteLine($"{weight}kg of {fruit} cost {price:C}.");

            Write("Type your name and press ENTER: ");
            string name = ReadLine();
            Write("Type your age and press: ENTER: ");
            string age = ReadLine();
            WriteLine($"Hello {name}, your look good for {age}.");

        }
    }
}
