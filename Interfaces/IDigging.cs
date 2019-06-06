using System;

namespace diggers_and_fliers
{
    public interface IDigging
    {
        void Dig();

        int MaximumDepth {get;}
    }
}