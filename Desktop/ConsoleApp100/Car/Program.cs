using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car auto = new Car();
            auto.CarName = "Scania";
            auto.CarColor = "Blue";

            auto.ShowCarStats();
            
            for (int i = 0; i<10; i++)
            {
                auto.CarRuns();
            }


            auto.ShowCarStats();

            Console.ReadLine();

        }
    }
}
