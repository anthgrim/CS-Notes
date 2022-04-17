using System;

namespace Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating
            var timeSpan1 = new TimeSpan(1, 2, 3);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);

            var duration = end - start;
            Console.WriteLine("Duration: {0}", duration);

            //Properties
            Console.WriteLine("Minutes: {0}", timeSpan1.Minutes);
            Console.WriteLine("Total Minutes: {0}", timeSpan1.TotalMinutes);

            //Add
            Console.WriteLine("Add: {0}",timeSpan1.Add(TimeSpan.FromMinutes(8)));

            //Subtract
            Console.WriteLine("Subtract: {0}", timeSpan1.Subtract(TimeSpan.FromMinutes(2)));

            //ToString
            Console.WriteLine("ToString: {0}", timeSpan1.ToString());

            //parse
            Console.WriteLine("Parse: {0}",TimeSpan.Parse("01:02:03"));

        
        }
    }
}
