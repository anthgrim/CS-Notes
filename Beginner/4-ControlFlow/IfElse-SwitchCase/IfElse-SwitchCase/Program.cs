using System;

namespace IfElse_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("Morning");
            }
            else if (hour > 12 && hour < 18)
            {
                Console.WriteLine("Afternoon");
            }
            else 
            {
                Console.WriteLine("Night");    
            }

            var isGoldCustomer = true;
            float price;

            if (isGoldCustomer)
            {
                price = 19.95f;
            }
            else
            {
                price = 29.95f;
            }
            Console.WriteLine(price);

            float price2 = (isGoldCustomer ? 19.95f : 29.95f);
            Console.WriteLine(price2);

            var season = SeasonEnum.Autumn;

            switch (season)
            {
                case SeasonEnum.Spring:
                    Console.WriteLine("It's spring");
                    break;
                case SeasonEnum.Summer:
                    Console.WriteLine("It's summer");
                    break;
                case SeasonEnum.Autumn:
                    Console.WriteLine("It's autumn");
                    break;
                default:
                    Console.WriteLine("It's winter");
                    break;
            }

        }
    }
}
