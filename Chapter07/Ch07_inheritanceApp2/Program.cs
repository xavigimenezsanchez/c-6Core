using Ch06_PackLibrary;
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch07_inheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee { Name = "John Jones", DateOfBirth = new DateTime(1990, 7, 28) };
            e1.EmployeeCode = "JJ001";
            e1.HireDate = new DateTime(2014, 11, 23);
            e1.WriteToconsole();
            WriteLine($"{e1.Name} was hired on {e1.HireDate:dd/MM/yy}");
            WriteLine(e1.ToString());

            Employee aliceInEmployee = new Employee { Name = "Alice", EmployeeCode = "AA123"};
            Person aliceInPerson = aliceInEmployee;
            aliceInEmployee.WriteToconsole();
            aliceInPerson.WriteToconsole();
            WriteLine(aliceInEmployee.ToString());
            WriteLine(aliceInPerson.ToString());


            if (aliceInPerson is Employee)
            {
                WriteLine($"{nameof(aliceInPerson)} IS an Employee");
                Employee e2 = (Employee)aliceInPerson;
            }

            Employee e3 = aliceInPerson as Employee;
            if (e3 != null)
            {
                WriteLine($"{nameof(aliceInPerson)} AS an Employee");
            }

            try
            {
                var ba = new BankAccount();
                ba.Balance = 100;
                WriteLine($"Balance is {ba.Balance}");
                ba.Withdraw(150);
                WriteLine($"Balance is {ba.Balance}");
            }
            catch (BadImageFormatException ex)
            {
                WriteLine($"{ex.GetType().Name}: {ex.Message}");
            }


            ReadKey();
        }
    }
}
