using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Plane.BL
{
    public class Airplane
    {
        public int AirplaneId { get; set; } //remember' an id of a plane doesn't change between landing and taking off
                                            //a flight number does!
                                            // public string Name { get; set; } //optional for the details
        public bool EngineState { get; set; } //on or off
        public bool IsTankFull { get; set; }

        [Range(1, 8)]
        public int StationId { get; set; }  //station number

    }
}
