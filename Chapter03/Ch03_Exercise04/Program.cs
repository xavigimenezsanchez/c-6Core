using System;
using static System.Console;

namespace Ch03_Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter a number between 1 and 255: ");
            string number1 = ReadLine();
            Write("Enter a number between 1 and 255: ");
            string number2 = ReadLine();
            try
            {
                var n1 = int.Parse(number1);
                var n2 = int.Parse(number2);
                if (n1 < 1 || n1 > 255 || n2 < 1 || n2> 255)
                {
                    throw new IndexOutOfRangeException();
                }
                WriteLine($"{number1} divided by {number2} is {n1 / n2}");
            } catch (FormatException)
            {
                WriteLine("FormatException: Input string was not in a correct format.");
            } catch (DivideByZeroException)
            {
                WriteLine("DivideByZeroException: Second number must not be 0");
            } catch (IndexOutOfRangeException)
            {
                WriteLine("IndexOutOfRangeException: Number must be between 1 and 255");
            }
        }
    }
}
