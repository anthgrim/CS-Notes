using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;

            Console.WriteLine((float)a / (float)b); //Using casting
            Console.WriteLine(a + b * c);

            //Comparison Operators
            Console.WriteLine(a > b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(!(a != b));

            //Logical Operators
            Console.WriteLine(c > b && c > a);
            Console.WriteLine(c > a && c == b);
            Console.WriteLine(a < b || b > c);
        }
    }
}
