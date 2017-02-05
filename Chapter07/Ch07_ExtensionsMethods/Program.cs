using Ch06_PackLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Ch07_ExtensionsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string email1 = "pamela@test.com";
            string email2 = "ian&text.com";

            WriteLine($"{email1} is a valid e-mail address: {email1.IsValidEmail()}.");
            WriteLine($"{email2} is a valid e-mail address: {email2.IsValidEmail()}.");

            ReadKey();
        }
    }
}
