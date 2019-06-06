using System;

namespace diggers_and_fliers
{
    public class Finch : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("The fince takes flight!");
        }

        public void BuildNest()
        {
            Console.WriteLine("The finch is building a nest");
        }

        public int MaximumHeight {get; set;}

        public override string ToString()
        {
            return $"The finch can fly {MaximumHeight} ft.";
        }
    }
}