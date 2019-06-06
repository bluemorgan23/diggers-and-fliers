using System;

namespace diggers_and_fliers
{
    public interface IWalking
    {
        void Run();
        void Walk();

        int AvgDistanceWalkedPerDay {get;}
    }
}