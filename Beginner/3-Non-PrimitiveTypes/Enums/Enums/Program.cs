using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    //Enum Declaration
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var shipMethod = ShippingMethod.Express;
            Console.WriteLine((int)shipMethod); //2

            var shipMethodId = 3;
            Console.WriteLine((ShippingMethod)shipMethodId); //Express

            var shipMethodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), shipMethodName);
            Console.WriteLine(shippingMethod); //Express
        }
    }
}
