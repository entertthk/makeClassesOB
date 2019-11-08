using System;

namespace OB
{
    //inheritance
    class Dog : Animal
    {
        public int spotCount = 0;
        public int numberOfBarks = 0;

        public void bark()
        {
            Console.WriteLine("Wuf");
            numberOfBarks++;
            levelOfHappiness += 0.1;
            Random rnd = new Random();
            int randomNumberOfSpots = rnd.Next(0, 6);
            spotCount += randomNumberOfSpots;

        }

        public void ShowNumberOfDogSpots()
        {
            Console.WriteLine($"{name} has now {spotCount} number of spots");
        }
    }
}