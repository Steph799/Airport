using System;
using System.Collections.Generic;
using System.Text;


namespace FinalProjectServer.BL.AirportBL
{
    public interface ITakingOff: IProcess, IGenerateFlight
    {
        void TakeOff();
    }
}
