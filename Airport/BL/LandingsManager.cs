using Airport.BL.Processes;
using Airport.Interfaces;

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Airport.BL
{
    //get a plane (from simulator) and do some tasks with it
    public class LandingsManager : ILandingsManager
    {
        bool _started = false;
        List<ILanding> _landings=new List<ILanding>();
        
   
        public void AddLanding(IAirplane airplane)
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            if(_started)
            {
                Trace.WriteLine($"==>{GetType().Name} already started");
                return;
            }

            _started = true;
            Trace.WriteLine($"==>{GetType().Name} is starting");
        }
    }
}
