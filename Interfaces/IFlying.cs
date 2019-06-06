using System;

namespace diggers_and_fliers
{
    public interface IFlying
    {
        void Fly();

        void BuildNest();

        int MaximumHeight {get;}
    }
}