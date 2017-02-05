using System;
using static System.Console;

namespace Ch06_PackLibrary
{
    public class Employee : Person
    {

        public string EmployeeCode { get; set; }
        public DateTime HireDate { get; set; }

        public override string ToString()
        {
            return $"{Name}'s code is {EmployeeCode}";
        }

        public override void WriteToconsole()
        {
            WriteLine($"{Name}'s birth date is {DateOfBirth:dd/MM/yy} and hire date was {HireDate:dd/MM/yy}");
        }
    }
}
