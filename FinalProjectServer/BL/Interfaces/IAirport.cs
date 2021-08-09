using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FinalProjectServer.BL.AirplaneBL;
using FinalProjectServer.Models;

namespace FinalProjectServer.BL.AirportBL
{
    public interface IAirport  
    {
        string GetMsgStatus();
        void StartAsync();
        AirportImage GetAirportImage();
        Task<AirportImage> GetCurrentProcesses();
        Task<List<FlightModel>> GetHistoryData();
    }  
}
