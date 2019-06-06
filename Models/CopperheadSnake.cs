using System;

namespace diggers_and_fliers
{
    public class CopperheadSnake : IWalking, ISwimming
    {
        public void Walk()
        {
            Console.WriteLine("The copperhead snake is slowly slithering along");
        }

        public void Run()
        {
            Console.WriteLine("The copperhead snake picks up the pace and is slithering fast as heck!");
        }

        public void Swim()
        {
            Console.WriteLine("The copperhead snake is swimming around!");
        }

        public int MaximumDepth {get; set;}

        public int AvgDistanceWalkedPerDay {get; set;}

        public override string ToString()
        {
            return $"The copperhead snake can burrow down {MaximumDepth} ft. It can also travel {AvgDistanceWalkedPerDay} miles on land per day.";
        }
    }
}