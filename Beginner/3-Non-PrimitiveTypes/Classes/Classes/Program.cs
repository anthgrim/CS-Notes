using System;
using Classes.Math;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.FirstName = "Kevin";
            person.LastName = "Grimaldi";

            person.Introduce();

            //Using Calculator class methods
            var add = Calculator.Add(1, 2);
            Console.WriteLine(add);

            var sub = Calculator.Subtract(1, 2);
            Console.WriteLine(sub);

            var mul = Calculator.Multiply(1, 2);
            Console.WriteLine(mul);

            var div = Calculator.Divide(1, 2);
            Console.WriteLine(div);
        }
    }
}
