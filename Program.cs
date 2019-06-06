using System;
using System.Collections.Generic;

namespace diggers_and_fliers
{
    class Program
    {
        static void Main(string[] args)
        {
            Parakeet parakeet = new Parakeet()
            {
                MaximumHeight = 40
            };

            Earthworm worm = new Earthworm()
            {
                MaximumDepth = 5,
                AvgDistanceWalkedPerDay = 0
            };

            Terrapin terrapin = new Terrapin()
            {
                MaximumDepth = 40,
                AvgDistanceWalkedPerDay = 1
            };

            TimberRattlesnake rattlesnake = new TimberRattlesnake()
            {
                MaximumDepth = 1,
                AvgDistanceWalkedPerDay = 2
            };

            Mouse mouse = new Mouse()
            {
                MaximumDepth = 2,
                AvgDistanceWalkedPerDay = 5
            };

            Ant ant = new Ant()
            {
                MaximumDepth = 4,
                AvgDistanceWalkedPerDay = 3
            };

            Finch finch = new Finch()
            {
                MaximumHeight = 40
            };

            BetaFish fish = new BetaFish()
            {
                MaximumDepth = 30
            };

            CopperheadSnake copperhead = new CopperheadSnake()
            {
                MaximumDepth = 1,
                AvgDistanceWalkedPerDay = 5
            };

            Gerbil gerbil = new Gerbil()
            {
                MaximumDepth = 1,
                AvgDistanceWalkedPerDay = 10
            };

            AnimalLists seperated = new AnimalLists()
            {
                LandAnimals = new List<IWalking>()
                {copperhead, rattlesnake},
                AnimalsOfTheSky = new List<IFlying>()
                {finch, parakeet},
                AnimalsThatDig = new List<IDigging>()
                {ant, gerbil, mouse, worm},
                SeaAnimals = new List<ISwimming>()
                {fish, terrapin}
            };

            Console.WriteLine("List of Land Animals: ");

           
            foreach(IWalking landAnimal in seperated.LandAnimals)
            {
                Console.WriteLine(landAnimal);
            }

            Console.WriteLine();
            Console.WriteLine("List of Flying Animals: ");

            foreach(IFlying skyAnimal in seperated.AnimalsOfTheSky)
            {
                Console.WriteLine(skyAnimal);
            }

            Console.WriteLine();
            Console.WriteLine("List of Digging Animals: ");

            foreach(IDigging diggingAnimal in seperated.AnimalsThatDig)
            {
                Console.WriteLine(diggingAnimal);
            }

            Console.WriteLine();
            Console.WriteLine("List of Sea Animals: ");

            foreach(ISwimming seaAnimal in seperated.SeaAnimals)
            {
                Console.WriteLine(seaAnimal);
            }
           

            Console.WriteLine();
        }
    }
}
