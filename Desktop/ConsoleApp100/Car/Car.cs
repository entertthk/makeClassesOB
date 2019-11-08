using System;

namespace Car
{
    public class Car
    {
        public string CarName;
        public string CarColor;
        public int CarOdometer = 0;
        public int CarFuelCons = 10;

        public void CarRuns()
        {
            //Console.WriteLine("Car drives");
            CarOdometer += 100;
            CarFuelCons += 1;
        }

        public void ShowCarStats()
        {
            Console.WriteLine(CarName);
            Console.WriteLine(CarColor);
            Console.WriteLine(CarOdometer);
            Console.WriteLine(CarFuelCons);

        }
    }
}
