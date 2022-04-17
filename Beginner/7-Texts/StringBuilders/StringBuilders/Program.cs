using System;
using System.Text;

namespace StringBuilders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();

            //Append
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10);
            Console.WriteLine(builder);

            //Replace
            builder.Replace('-', '+');
            Console.WriteLine(builder);

            //Remove
            builder.Remove(0, 10);
            Console.WriteLine(builder);

            //Insert
            builder.Insert(0, new string('-',10));
            Console.WriteLine(builder);

            //Index
            Console.WriteLine("First character: {0}", builder[0]);

        }
    }
}
