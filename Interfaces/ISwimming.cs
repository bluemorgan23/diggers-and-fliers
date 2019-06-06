using System;

namespace diggers_and_fliers
{
    public interface ISwimming
    {
        int MaximumDepth { get; }
        void Swim();
    }
}