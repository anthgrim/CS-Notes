using System;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implicit Type Conversion
            byte b = 1;
            int i = b;

            Console.WriteLine(i);

            //Data Lost
            int c = 1000;
            byte d = (byte)c; //Using casting

            Console.WriteLine(d);

            //Non-Compatible Types

            try
            {
                var number = "1234";
                var k = byte.Parse(number);
                Console.WriteLine(k);
            }
            catch (Exception)
            {
                Console.WriteLine("The variable number could not be converted into a byte");
            }

            try
            {
                var str = "true";
                var isTrue = bool.Parse(str);

                Console.WriteLine(isTrue);
            }
            catch (Exception)
            {
                Console.WriteLine("The variable str could not be converted into a boolean");
            }
        }
    }
}
