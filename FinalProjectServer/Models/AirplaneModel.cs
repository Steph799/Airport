using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FinalProjectServer.Models
{
    public class AirplaneModel
    {
        [Key]
        public int AirplaneId { get; set; } //remember an id of a plane doesn't change between landing and taking off
                                            //a flight number does!
        public DateTime CreatingTime { get; set; }                               

        public int StationId { get; set; }  //station number 

        //list of flights?
    }
}
