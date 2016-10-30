using System;
using static System.Console;

namespace Ch03_Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 100;
            for (int x = 1; x <= max; x++)
            {
                var three = x % 3;
                var five = x % 5;
                if (three == 0 && five == 0)
                {
                    Write("FizzBuzz");
                }
                if (three == 0)
                {
                    Write("Fizz");
                } else if (five == 0)
                {
                    Write("Buzz");
                } else
                {
                    Write(x);
                }
                if (x <100)
                {
                    Write(", ");
                }
            }
        }
    }
}
