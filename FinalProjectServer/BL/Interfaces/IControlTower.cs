using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using FinalProjectServer.BL.AirplaneBL;
using FinalProjectServer.BL.StationBL;
using FinalProjectServer.Models;

namespace FinalProjectServer.BL.AirportBL
{
    public interface IControlTower
    {
        event EventHandler OnChanged;
        event EventHandler<StationModel> OnStationStateChanged;
        event EventHandler<FlightObject> OnAddFlight;
        void Start();      
        void CheckFlightsAsync();
        bool UpdateStations();
        List<ProcessStatusModel> GetAllStatuses(); //of flights    
        bool PrioriryStatus();
        bool ItertaionIsOver();       
    }
}
