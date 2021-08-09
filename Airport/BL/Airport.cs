using Airport.Interfaces;
using System;
using System.Diagnostics;

namespace Airport.BL
{
    public class Airport : IAirport
    {
        //ILandingsManager _landingsManager;
        //ITakeoffsManager _takeoffsManager;
        IControlTower _controlTower;
      

        public Airport(/*ILandingsManager landingsManager, ITakeoffsManager takeoffsManager,*/ IControlTower controlTower)
        {
            //_landingsManager = landingsManager;
            //_takeoffsManager = takeoffsManager;
            _controlTower = controlTower;
        }

        bool _started = false;
        public void Start()
        {
            //_landingsManager.Start();
            //_takeoffsManager.Start();
            _controlTower.Start();
        }
    }
}
