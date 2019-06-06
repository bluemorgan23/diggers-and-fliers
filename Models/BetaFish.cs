using System;

namespace diggers_and_fliers
{
    public class BetaFish : ISwimming
    {
        public void Swim()
        {
            Console.WriteLine("The beta fish is swimming around!");
        }

        public int MaximumDepth {get; set;}

        public override string ToString()
        {
            return $"The beta fish can swim down to {MaximumDepth} ft.";
        }
    }
}