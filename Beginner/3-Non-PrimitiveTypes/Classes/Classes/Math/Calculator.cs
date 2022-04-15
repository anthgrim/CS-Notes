using System;

namespace Classes.Math
{
    public class Calculator
    {
        //List of Methods/Functions

        //Add Method
        public static int Add(int a, int b)
        {
            return a + b;
        }

        //Subtract
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        //Multiply
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        //Divide
        public static float Divide(int a, int b)
        {
            try
            {
                return (float)a / (float)b;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
