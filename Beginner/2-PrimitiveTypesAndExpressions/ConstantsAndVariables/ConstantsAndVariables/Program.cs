using System;

namespace ConstantsAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            var number = 2;
            var count = 10;
            var totalPrice = 10.97f;
            var character = 'A';
            var firstName = "Kevin";
            var isWorking = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            //Format String
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            //Constants
            const float Pi = 3.14f;
            const string LastName = "Grimaldi";

            Console.WriteLine(Pi);
            Console.WriteLine(LastName);
        }
    }
}
