using System;

namespace diggers_and_fliers
{
    public class Mouse : IWalking, IDigging
    {
        public void Walk()
        {
            Console.WriteLine("The mouse is slowly walking around");
        }

        public void Run()
        {
            Console.WriteLine("The mouse starts moving with some quickness!");
        }

        public void Dig()
        {
            Console.WriteLine("The mouse is digging down into a burrow in the ground");
        }
        public int MaximumDepth {get; set;}
        public int AvgDistanceWalkedPerDay {get; set;}

        public override string ToString()
        {
            return $"The mouse can dig down {MaximumDepth} ft. It can also travel {AvgDistanceWalkedPerDay} miles per day on land.";
        }
    }
}