using System;
using System.Collections.Generic;
using System.Text;
using FinalProjectServer.BL.AirplaneBL;
using FinalProjectServer.BL.StationBL;
using FinalProjectServer.Models;
using LandingSimulator;

namespace FinalProjectServer.BL.AirportBL
{
    public interface ILandingsManager
    {
        void Start();
        LandingRoute GetLandingRoute(List<IStationManager> stations);
    }
}
