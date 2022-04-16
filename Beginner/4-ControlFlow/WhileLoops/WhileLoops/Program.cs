using System;

namespace WhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Type your name:");
                var userInput = Console.ReadLine();
                
                if (!String.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Echo: {0}", userInput);
                    continue;
                }

                break;
            }
        }
    }
}
