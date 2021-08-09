using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.BL;
using Airport.BL.Processes;
using Airport.Interfaces;

namespace Airport.BL
{
    public class ControlTower: IControlTower
    {
        public LandingsManager _landingsManager { get; set; }
        public TakeoffsManager _takeoffsManager { get; set; }
        public List<IProcess> _processes { get; set; }  //process can be landing or taking off (all of those are flights)
       
        public Station[] stations { get; set; }
        public ControlTower(LandingsManager landingsManager, TakeoffsManager takeoffsManager, List<IProcess> processes)
        {
            _landingsManager = landingsManager;
            _takeoffsManager = takeoffsManager;
            _processes = processes;
        }

      
        public void Start()
        {
            _landingsManager.Start();
            _takeoffsManager.Start();
        }


        public void GetCurrentState(int flyNum)
        {
            throw new NotImplementedException();
        }

        public void SendMsg(int flyNum, bool canProceed)
        {
            throw new NotImplementedException();
        }

        public void ToggleStationStatus(int stationNum)
        {
            throw new NotImplementedException();
        }
    }
}
