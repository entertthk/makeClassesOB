using System;

namespace OB
{
    class Hamster : Animal
    {
        public int weight = 0;

        public void run()
        {
            Console.WriteLine("Hamster runs");
            weight -= 7;
        }
        public void ShowWeight()
        {
            Console.WriteLine($"Hamster {name} has now {weight} Kg");
        }

    }
}