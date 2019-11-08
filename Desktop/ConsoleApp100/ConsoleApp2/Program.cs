using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{


    class Program
    {
        static void Main(string[] args)
        {
            Person Marko = new Person();
            //Marko.FirstName = Console.ReadLine();
            Marko.FirstName = "Okram";
            Marko.LastName = "Rebak";

            Marko.Introduce();


            Console.ReadLine();
        }
    }
}
