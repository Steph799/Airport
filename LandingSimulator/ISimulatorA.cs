using System;
using System.Collections.Generic;
using System.Timers;

namespace LandingSimulator
{
    public interface ISimulatorA<T>
    {
        void GenerateLanding(List<T> processes);
    }
}
