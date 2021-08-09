using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Interfaces
{
    public interface IControlTower
    {
        void Start();
        void GetCurrentState(int flyNum); //get the current situation from a plane
        void SendMsg(int flyNum, bool canProceed); //send message to a specific airplane
        void ToggleStationStatus(int stationNum);
    }
}
