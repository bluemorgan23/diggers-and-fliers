using System;

namespace diggers_and_fliers
{
    public class Gerbil : IWalking, IDigging
    {
        public void Walk()
        {
            Console.WriteLine("The Gerbil is slowly walking around");
        }
        public void Run()
        {
            Console.WriteLine("The Gerbil is rapidly running around in a bunch of different directions! Slow down buddy!");
        }

        public void Dig()
        {
            Console.WriteLine("The Gerbil is burrowing down into a hole in the ground.");
        }
        public int MaximumDepth {get; set;}
        public int AvgDistanceWalkedPerDay {get; set;}

        public override string ToString()
        {
            return $"The gerbil can dig down {MaximumDepth} ft. It can also travel {AvgDistanceWalkedPerDay} miles per day.";
        }
    }
}