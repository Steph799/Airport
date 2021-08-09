using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectServer.BL.AirplaneBL;
using FinalProjectServer.Models;

namespace FinalProjectServer.BL.StationBL
{
    public interface IStationManager
    {
        bool isAvailable();
        int GetStationId();
        StationType GetTypeOfStation();
        void EnterToStation(AirplaneObject airplane);
        void ExitFromStation();
        AirplaneObject GetAirplane();
        StationModel GetStation();
    }
}
