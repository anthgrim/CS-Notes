using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5_ControlFlow_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Instructions:
             * Write a program that request a number from the user. If the number is a value
             * between 1 and 10,then print valid. Otherwise, print invalid
             */

            Console.WriteLine("Please input a number");
            var userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput >= 1 && userInput <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            /*
             * Instructions:
             * Write a program that counts how many numbers between 1 and 100 are divisible by 3 with
             * no remainder.Display the count in the console
             */

            var counter = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine("\nNumbers divisible by 3: {0}", counter);

            /*
             * Instructions:
             * Write a program that request a number from the user or "ok" to exit.
             * Calculate the sum of all the numbers entered and display it in the console
             */

            var numbersArrA = new int[1];

            while (true)
            {
                Console.WriteLine("\nPlease enter a number:");
                var input = Console.ReadLine();

                if (input != "ok")
                {
                    var numInput = Convert.ToInt32(userInput);
                    numbersArrA[numbersArrA.Length - 1] = numInput;

                    Array.Resize(ref numbersArrA, numbersArrA.Length + 1);
                    continue;
                }
                else
                {
                    var total = 0;
                    for (int i = 0; i < numbersArrA.Length; i++)
                    {
                        total += numbersArrA[i];
                    }
                    Console.WriteLine("Your total is: {0}", total);
                    break;
                }
            }

            /*
             * Instructions:
             * Write a program that displays the factorial of the number entered by the user
             */

            Console.WriteLine("\nFactorial of:");
            var numFactorial = Convert.ToInt32(Console.ReadLine());
            var factorial = 1;

            for (int i = 1; i <= numFactorial; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("{0}!: {1}\n", numFactorial, factorial);

            /*
             * Instructions:
             * Write a program that picks a random number between 1 and 10.
             * Give the user 4 chances to guess the number. If the user guesses the
             * number, display "you won"; otherwise, display "you lost"
             */

            var chances = 0;
            var ranClass = new Random();
            var ranNumber = ranClass.Next(1, 11);

            while (true)
            {
                chances++;
                Console.WriteLine("Guess the number:");
                var userInput2 = Convert.ToInt32(Console.ReadLine());

                if (userInput2 == ranNumber)
                {
                    Console.WriteLine("You won");
                }
                else if (chances < 5 && userInput2 != ranNumber)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("You lost");
                    break;
                }
            }

            /*
             * Instruction:
             * Write a program that request the user a series of numbers separated by comma.
             * Find the maximum of the numbers and display it in the console.
             */

            Console.WriteLine("Please enter a series of numbers separated by comma");
            var userInput3 = Console.ReadLine();

            var inputArray = userInput3.Split(',');

            foreach (var number in inputArray)
            {
                int.Parse(number);
            }

            var maxNum = inputArray.Max();
            Console.WriteLine("Maximum number in the series is: {0}", maxNum);

        }
    }
}
