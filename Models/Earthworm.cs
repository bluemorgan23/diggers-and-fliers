using System;

namespace diggers_and_fliers
{
    public class Earthworm : IDigging, IWalking
    {
        public void Walk()
        {
            Console.WriteLine("The Earthworm is slowly crawling around... Can't go much faster than this.");
        }

        public void Run()
        {
            Walk();
        }

        public void Dig()
        {
            Console.WriteLine("The earthworm is digging down into the earth, it has almost made it to the Earth's core.");
        }

        public int MaximumDepth {get; set;}

        public int AvgDistanceWalkedPerDay {get; set;}

        public override string ToString()
        {
            return $"The earthworm can dig down to {MaximumDepth} ft. It travels an average of {AvgDistanceWalkedPerDay} miles per day by land.";
        }
    }
}