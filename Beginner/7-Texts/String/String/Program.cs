using System;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fullName = "John Doe ";

            //Trim
            Console.WriteLine("Trim: '{0}'", fullName.Trim());

            //ToUpper
            Console.WriteLine("ToUpper: '{0}'", fullName.ToUpper());

            //ToLower
            Console.WriteLine("ToLower: '{0}'", fullName.ToLower());

            //Break String in First Name and Last Name
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: {0}", firstName);
            Console.WriteLine("Last Name: {0}", lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("First Name: {0}", names[0]);
            Console.WriteLine("Last Name: {0}", names[1]);

            var fullNameNew = fullName.Replace("John", "Johnas");
            Console.WriteLine(fullNameNew);

            if (String.IsNullOrWhiteSpace("    "))
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("Valid");
            }

            //Numbers to string
            var str = "25";
            var age = byte.Parse(str);
            Console.WriteLine(age);

            var price = 29.95;
            var priceStr = price.ToString("C");
            Console.WriteLine(priceStr);
        }
    }
}
