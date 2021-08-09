using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectServer.BL.StationBL;
using FinalProjectServer.Models;

namespace FinalProjectServer.BL.AirportBL
{
    public interface IRoute
    {
        List<IStationManager> Route { get; }
        bool IsNextStationFree(int Loaction);
        int GetNextStation(int Loaction);
        void ProceedToNextStaion(IProcess process);
    }
}
