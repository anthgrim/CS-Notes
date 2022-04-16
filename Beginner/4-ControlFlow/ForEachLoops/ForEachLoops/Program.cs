using System;

namespace ForEachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array
            var numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i +1;
            }

            Console.WriteLine("Numbers in the Array");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //String
            Console.WriteLine("\nName string using For loop");
            var name = "John Doe";
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            Console.WriteLine("\nName string using For Each");
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

        }
    }
}
