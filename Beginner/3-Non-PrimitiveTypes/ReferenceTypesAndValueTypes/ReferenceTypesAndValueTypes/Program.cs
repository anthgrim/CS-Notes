using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypesAndValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;

            //B is now 11 and a is 10
            //Primitive Types are value types
            Console.WriteLine("a is {0} and b is {1}", a, b);

            //Reference Types
            var array1  = new int[3] {1,2,3};
            var array2 = array1;
            Console.WriteLine("\nBefore change");
            Console.WriteLine("Array1 at 0: {0}\nArray2 at 0: {1}", array1[0], array2[0]);

            array2[0] = 0;

            //Arrays are reference types
            //Both variables are pointing to the same address in the memory
            Console.WriteLine("\nAfter change");
            Console.WriteLine("Array1 at 0: {0}\nArray2 at 0: {1}", array1[0], array2[0]);

            //Using class
            var person = new Person();
            person.FirstName = "John";
            person.LastName = "Whick";
            person.Age = 45;

            Console.WriteLine("Current Age: {0}", person.Age);

            Console.WriteLine("Increased Age: {0}", person.IncreaseAge(10));

            Console.WriteLine("Decreased Age: {0}", person.DecreaseAge(5));

            person.Introduce();
        }
    }
}
