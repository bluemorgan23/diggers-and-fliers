using System;

namespace diggers_and_fliers
{
    public class Parakeet : IFlying
    {
        public void Fly()
        {
            Console.WriteLine($"The {this.GetType().Name} is flying away!");
        }

        public void BuildNest()
        {
            Console.WriteLine($"The {this.GetType().Name} is building a nest.");
        }

        public int MaximumHeight {get; set;}

        public override string ToString()
        {
            return $"The parakeet can fly {MaximumHeight} ft.";
        }
    }
}