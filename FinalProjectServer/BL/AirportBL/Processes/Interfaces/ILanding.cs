using System;
using System.Collections.Generic;
using System.Text;
using FinalProjectServer.BL.AirplaneBL;
using FinalProjectServer.BL.StationBL;

namespace FinalProjectServer.BL.AirportBL
{
    public interface ILanding : IProcess, IGenerateFlight
    {
        void Land();
    }
}
