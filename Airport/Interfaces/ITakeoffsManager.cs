using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Interfaces
{
    public interface ITakeoffsManager
    {
        void Start();
        void AddLanding(IAirplane airplane);
    }
}
