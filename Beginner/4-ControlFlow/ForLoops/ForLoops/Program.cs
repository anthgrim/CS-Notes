using System;

namespace ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            //Logging only even numbers in the array
            Console.WriteLine("Even Numbers in the array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            //Logging even numbers in the array in reverse order
            Console.WriteLine("\nEven Numbers in the array in reverse order");
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
