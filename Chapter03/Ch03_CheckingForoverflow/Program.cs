using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03_CheckingForoverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                try
                {
                    int x = int.MaxValue - 1;
                    WriteLine(x);
                    x++;
                    WriteLine(x);
                    x++;
                    WriteLine(x);
                    x++;
                    WriteLine(x);
                }
                catch (OverflowException)
                {
                    WriteLine("The code overflowed but I caught the exception.");
                }
            }
            unchecked
            {
                int x = int.MaxValue + 1;
                WriteLine(x);
                x--;
                WriteLine(x);
                x--;
                WriteLine(x);
            }
        }
    }
}
