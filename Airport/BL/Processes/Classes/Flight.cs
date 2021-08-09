using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AirportLogic.BL.Processes
{
    public class Flight
    {
        [Range(100, 1000000)]
        public int FlightId { get; set; }

        //  public int FlightNum { get; set; } //should the flightid be the flight num??
        public bool FightCategory { get; set; } // true=landing/false=taking off
        public int AirplaneId { get; set; }
        //public virtual Airplane Airplane { get; set; }
        public DateTime EstimateProcessTime { get; set; } //the exact hour to be in the field (station number 4)
    }
}
