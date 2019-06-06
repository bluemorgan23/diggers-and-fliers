using System;

namespace diggers_and_fliers
{
    public class Ant : IWalking, IDigging
    {
        public void Walk()
        {
            Console.WriteLine("The ant is slowly walking along");
        }

        public void Run()
        {
            Console.WriteLine("The ant picks up the pace and is running around like crazy!");
        }

        public void Dig()
        {
            Console.WriteLine("The ant is digging down into the ant pile");
        }

        public int MaximumDepth {get; set;}

        public int AvgDistanceWalkedPerDay {get; set;}

        public override string ToString()
        {
            return $"The ant can burrow down {MaximumDepth} ft. It can also travel {AvgDistanceWalkedPerDay} miles on land per day.";
        }
    }
}