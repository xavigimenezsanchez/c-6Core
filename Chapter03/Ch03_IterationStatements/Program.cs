using System;
using static System.Console;

namespace Ch03_IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x < 10)
            {
                WriteLine(x);
                x++;
            }

            int y = 0;
            do
            {
                WriteLine(y);
                y++;
            } while (y < 10);

            for (int z = 0; z < 10; z++)
            {
                WriteLine(z);
            }

            string[] names = { "Adam", "Barry", "Charlie" };
            foreach (string name in names)
            {
                WriteLine($"{name} has {name.Length} characters.");
            }
        }
    }
}
