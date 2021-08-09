using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectServer.BL.AirplaneBL;
using FinalProjectServer.Models;

namespace FinalProjectServer.BL.AirportBL
{
    public interface IGenerateFlight
    {
        FlightObject GenerateFlight(AirplaneObject airplane);
    }
}
