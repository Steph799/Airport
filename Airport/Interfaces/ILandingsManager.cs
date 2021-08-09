using System;
using System.Collections.Generic;
using System.Text;
using FinalProjectServer.Repositories;

namespace Airport.Interfaces
{
    public interface ILandingsManager
    {
        void Start();
        void AddLanding(IAirplane airplane);
    }
}
