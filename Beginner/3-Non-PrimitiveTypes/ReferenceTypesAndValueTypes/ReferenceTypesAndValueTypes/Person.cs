using System;

namespace ReferenceTypesAndValueTypes
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        //Methods
        public int IncreaseAge(int increment)
        {
            try
            {
                return Age += increment;
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to increment age");
                return -1;
            }
        }

        public int DecreaseAge(int decrease)
        {
            try
            {
                return Age -= decrease;
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to decrease age");
                return -1;
            }
        }

        public void Introduce()
        {
            Console.WriteLine("Hello, my name is {0} {1} and I am {2} years old", FirstName, LastName, Age);
        }
    }
}
