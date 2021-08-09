using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjectServer.BL.AirportBL
{
    public interface IProcess
    {
        ProcessStatusObject GetStatus(); //flight num, airplaneId, process, station, task status
        void TimeInStation();
    }
}
