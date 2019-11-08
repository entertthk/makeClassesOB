using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OB
{



    class Program
    {
        static void Main(string[] args)
        {
            Animal nurr = new Animal();
            nurr.name = "Nurr";
            nurr.age = 15;
            nurr.levelOfHappiness = 0.1;

            nurr.PrintAnimalBaseInfo();



            Dog Scooby = new Dog();
            Scooby.name = "ScoobyDoo";
            Scooby.age = 10;
            Scooby.levelOfHappiness = 0.1;
            Scooby.spotCount = 3;
            
           

            Cat Tom = new Cat();
            Tom.name = "TommyJe";
            Tom.age = 1;
            Tom.levelOfHappiness = 1;
            Tom.levelOfCuteness = 10;
            //cat meow
            for (int i = 0; i < 10; i++)
            {
                Tom.mjau();

            }
            Tom.ShowCuteness();
            //dog barks
            for (int i = 0; i < 50; i++)
            {
                Scooby.bark();
            }
            //kass kuuleb koera haukumist
            Tom.HearBarks(Scooby.numberOfBarks);
            if (Tom.levelOfHappiness < 0)
            {
                Console.WriteLine($"{Tom.name} died of stress");
                Tom = null;
            }


            Scooby.ShowLevelHappiness();
            Scooby.ShowNumberOfDogSpots();

            Hamster Jack = new Hamster();
            Jack.name = "Jackson";
            Jack.age = 12;
            Jack.levelOfHappiness = 1;
            Jack.weight = 100;

            Jack.run();
            Jack.ShowWeight();


            Console.ReadLine();
        }
    }
}