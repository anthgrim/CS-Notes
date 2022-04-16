using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generate random ints, floats, etc...
            //https://docs.microsoft.com/en-us/dotnet/api/system.random?view=net-6.0

            var random = new Random();
            const int passwordLength = 10;
            var buffer = new char[passwordLength];

            for (int i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }

            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
