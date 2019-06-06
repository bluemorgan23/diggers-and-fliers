using System;

namespace diggers_and_fliers
{
    public class Terrapin : ISwimming, IWalking
    {
        public void Swim()
        {
            Console.WriteLine("The Terrapin is swimming in the deep sea.");
        }

        public void Walk()
        {
            Console.WriteLine("The terrapin is slowly walking along!");
        }

        public void Run()
        {
            Walk();
        }

        public int AvgDistanceWalkedPerDay {get; set;}

        public int MaximumDepth {get; set;}

        public override string ToString()
        {
            return $"The terrapin can swim down to {MaximumDepth} ft. It can also travel {AvgDistanceWalkedPerDay} miles per day on land.";
        }
    }
}