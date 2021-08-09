using Airport.Interfaces;
using System;
using System.Diagnostics;

namespace Airport.BL
{
    public class TakeoffsManager: ITakeoffsManager
    {
        bool _started = false;

        public void AddLanding(IAirplane airplane)
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            if (_started)
            {
                Trace.WriteLine($"==>{GetType().Name} already started");
                return;
            }

            _started = true;
            Trace.WriteLine($"==>{GetType().Name} is starting");
        }
    }
}
