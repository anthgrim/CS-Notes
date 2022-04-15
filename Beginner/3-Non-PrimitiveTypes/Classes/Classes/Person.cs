using System;

namespace Classes
{
    public class Person
    {
        //Properties/Attributes
        public string FirstName;
        public string LastName;

        //Method/Function
        public void Introduce()
        {
            Console.WriteLine("My name is {0} {1}", FirstName, LastName);
        }
    }
}
