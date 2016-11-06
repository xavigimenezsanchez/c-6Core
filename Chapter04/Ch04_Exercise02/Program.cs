using System;
using System.Text.RegularExpressions;
using static System.Console;


namespace Ch04_Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\d+$");
            do
            {
                WriteLine("The default regualar expression checks for at least one digit.");
                Write("Enter a regular expression (or press ENTER to user the default):");
                string regexStrin = ReadLine();
                try
                {
                    regex = new Regex(regexStrin);
                } catch (ArgumentException)
                {
                    regex = new Regex(@"\d+$");
                }
                Write("Enter Some input: ");
                string input = ReadLine();
                WriteLine($"{input} maches {regex}? {regex.IsMatch(input)}");
                Write("Enter ESC to end or any key to try again");

            } while (ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
