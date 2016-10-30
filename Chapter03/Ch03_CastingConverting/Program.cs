using System;
using static System.Console;
using static System.Convert;

namespace Ch03_CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = a + 0.5;
            int c = (int)b;
            WriteLine(a);
            WriteLine(b);
            WriteLine(c);
            WriteLine("---------------------------");

            long e = 10;
            int f = (int)e;
            WriteLine($"e is {e} and f is {f}");
            e = long.MaxValue;
            f = (int)e;
            WriteLine($"e is {e} and f is {f}");
            WriteLine("---------------------------");

            double g = 9.8;
            int h = ToInt32(g);
            WriteLine($"g is {g} and h is {h}");

            WriteLine("---------------------------");
            WriteLine("----Rounding Numbers-------");

            double i = 9.49;
            double j = 9.5;
            double k = 10.49;
            double l = 10.5;

            WriteLine($"i is {i}, ToInt(i) is {ToInt32(i)}");
            WriteLine($"j is {j}, ToInt(j) is {ToInt32(j)}");
            WriteLine($"k is {k}, ToInt(k) is {ToInt32(k)}");
            WriteLine($"l is {l}, toInt(l) is {ToInt32(l)}");


            WriteLine("-------------------------------------------");
            WriteLine("----Converting from any type to a string----");

            int number = 12;
            WriteLine(number.ToString());
            bool boolean = true;
            WriteLine(boolean.ToString());
            DateTime now = DateTime.Now;
            WriteLine(now.ToString());
            object me = new object();
            WriteLine(me.ToString());

            WriteLine("---------------------------------------------------------");
            WriteLine("----Parsin from strings to numbers or dates and times----");

            int age = int.Parse("44");
            DateTime birthday = DateTime.Parse("17 November 1971");
            WriteLine($"i was born {age} years ago.");
            WriteLine($"My birthday is {birthday}.");
            WriteLine($"My birthday is {birthday:D}.");

            WriteLine("------------------------");
            WriteLine("----Parsin: TryParse----");

            Write("How may eggs are there? ");
            int count;
            string input = ReadLine();
            if (int.TryParse(input, out count))
            {
                WriteLine($"There are {count} eggs.");
            }
            else
            {
                WriteLine("I could not parse the input.");
            }
        }
    }
}
