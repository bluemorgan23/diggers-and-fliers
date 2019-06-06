using System;

namespace diggers_and_fliers
{
    public class TimberRattlesnake : IWalking, ISwimming
    {
        public void Run()
        {
            Console.WriteLine("The rattlesnake slithers at an incredible speed!");
        }

        public void Walk()
        {
            Console.WriteLine("The rattlesnake is slowly slithering along.");
        }

        public void Swim()
        {
            Console.WriteLine("The Rattlesnake is swimming around!");
        }

        public int MaximumDepth {get; set;}
        public int AvgDistanceWalkedPerDay {get; set;}

        public override string ToString()
        {
            return $"The rattlesnake can swim down {MaximumDepth} ft. It also can travel {AvgDistanceWalkedPerDay} miles on land per day.";
        }
    }
}