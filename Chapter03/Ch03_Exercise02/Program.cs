using System;
using static System.Console;

namespace Ch03_Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            //int max = 500;  // this code has no end because of max byte is 255 and for never end
            int max = byte.MaxValue;
            for (byte i = 0; i < max; i++)
            {
                WriteLine(i);
            }
        }
    }
}
