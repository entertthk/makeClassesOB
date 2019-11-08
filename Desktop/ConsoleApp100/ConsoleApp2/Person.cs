using System;

namespace ConsoleApp2
{
    public class Person
    {
        public string FirstName; //fields
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {FirstName} {LastName}");
        }
    }
}
