using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generic Lists
            var numbers = new List<int>() { 1,2,3,4};

            //Add
            numbers.Add(1);

            //AddRange
            numbers.AddRange(new int[5] {5,6,7,1,1});

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //IndexOf
            Console.WriteLine("\nIndex of 1: " + numbers.IndexOf(1));

            //LastIndexOf
            Console.WriteLine("\nLast Index of 1: " + numbers.LastIndexOf(1));

            //Count
            Console.WriteLine("\nCount: " + numbers.Count);

            //Remove
            Console.WriteLine("\nRemove all 1s");
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //Clear
            numbers.Clear();
            Console.WriteLine("\nConfirm Clear. Total list count: " + numbers.Count);
        }
    }
}
