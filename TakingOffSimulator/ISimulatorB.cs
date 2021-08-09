using System;
using System.Collections.Generic;
using System.Timers;

namespace TakingOffSimulator
{
    public interface ISimulatorB<T>
    {
        void GenerateTakingOff(List<T> processes);
    }
}
