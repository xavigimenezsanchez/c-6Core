using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02_Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("-----------------------------------------------------------------------------------------------");
            WriteLine("{0,-9} {1,-20}{2,30}{3,35}", "Type", "Byte(s) of memory", "Min", "Max");
            WriteLine("-----------------------------------------------------------------------------------------------");
            WriteLine("{0,-9} {1,-20}{2,30}{3,35}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            WriteLine("{0,-9} {1,-20}{2,30}{3,35}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
            WriteLine("{0,-9} {1,-20}{2,30}{3,35}", "short", sizeof(short), short.MinValue, short.MaxValue);
            WriteLine("{0,-9} {1,-20}{2,30}{3,35}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            WriteLine("{0,-9} {1,-20}{2,30}{3,35}", "int", sizeof(int), int.MinValue, int.MaxValue);
            WriteLine("{0,-9} {1,-20}{2,30}{3,35}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
            WriteLine("{0,-9} {1,-20}{2,30}{3,35}", "long", sizeof(long), long.MinValue, long.MaxValue);
            WriteLine("{0,-9} {1,-20}{2,30}{3,35}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
            WriteLine("{0,-9} {1,-20}{2,30}{3,35}", "float", sizeof(float), float.MinValue, float.MaxValue);
            WriteLine("{0,-9} {1,-20}{2,30}{3,35}", "double", sizeof(double), double.MinValue, double.MaxValue);
            WriteLine("{0,-9} {1,-20}{2,30}{3,35}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
            WriteLine("-----------------------------------------------------------------------------------------------");
        }
    }
}
