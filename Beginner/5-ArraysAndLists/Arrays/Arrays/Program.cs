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
            var numbers = new int[3] {1,2,3};

            //Length
            Console.WriteLine(numbers.Length);

            //IndexOf
            var index = Array.IndexOf(numbers, 3);
            Console.WriteLine("Index of 3: {0}\n", index);

            //Clear
            Array.Clear(numbers, 0, 2); //Sets to 0, false, or null depending on the type
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //Copy
            var newArray = new int[numbers.Length];
            Array.Copy(numbers, newArray, numbers.Length);
            Console.WriteLine("\nCopied Array:");
            foreach (var number in newArray)
            {
                Console.WriteLine(number);
            }

            //Sort
            Console.WriteLine("\nSorting:");
            Array.Sort(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //Reverse
            Console.WriteLine("\nReverse:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
