using System;
using System.Collections.Generic;
using System.Text;
using FinalProjectServer.BL.AirplaneBL;
using FinalProjectServer.BL.StationBL;
using FinalProjectServer.Models;

namespace FinalProjectServer.BL.AirportBL
{
    public interface ITakeoffsManager
    {
        void Start();      
        DepartureRoute GetDepartureRoute(List<IStationManager> stations);
    }
}
