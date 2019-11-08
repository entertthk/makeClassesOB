using System;

namespace OB
{
    class Animal
    {
        public string name;
        public int age;
        public double levelOfHappiness;

        public void PrintAnimalBaseInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Level of happiness: {levelOfHappiness}");
        }

        public void ShowLevelHappiness()
        {
            Console.WriteLine($"{name} has level of happiness: {levelOfHappiness}");
        }

    }
}