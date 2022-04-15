using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]); //1
            Console.WriteLine(numbers[1]); //0
            Console.WriteLine(numbers[2]); //0

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]); //TRUE
            Console.WriteLine(flags[1]); //FALSE
            Console.WriteLine(flags[2]); //FALSE

            var names = new string[3] {"Jack","John","Mary"};
        }
    }
}
