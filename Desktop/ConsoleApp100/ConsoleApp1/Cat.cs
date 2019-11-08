using System;

namespace OB
{
    class Cat : Animal
    {
        public int levelOfCuteness = 0;

        public void mjau()
        {
            Console.WriteLine("Mjau");
            levelOfCuteness -= 1;
            levelOfHappiness += 0.2;

        }
        public void ShowCuteness()
        {
            Console.WriteLine($"{name} has now {levelOfCuteness} level Cuteness and {levelOfHappiness} level happiness");
        }
        public void HearBarks(int numberOfBarks)
        {
            levelOfHappiness -= 0.1 * numberOfBarks;
        }

    }
}