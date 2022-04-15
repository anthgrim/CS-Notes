using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Kevin";
            var lastName = "Grimaldi";

            //Concatenation
            var fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            //String Format
            var fullNameB = string.Format("{0} {1}", firstName, lastName);
            Console.WriteLine(fullNameB);

            //String Join
            var names = new string[3] { "John", "Wick", "Mary" };

            var list = string.Join(",", names);
            Console.WriteLine(list);

            //Verbatim Strings
            var text = @"Hi John
Look into the following
attachments:";
            Console.WriteLine(text);
        }
    }
}
