using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectServer.BL.AirportBL;

namespace FinalProjectServer.Models
{
    public class ProcessStatusModel
    {
        [Key]
        public int Index { get; set; }
        public int FlightNum { get; set; }
        public int AirplaneId { get; set; }
        public bool IsLanding { get; set; } 
        public int StationNum { get; set; }
        public bool IsTaskDone { get; set; }                                                
        public DateTime CreationTime { get; set; }
    //    public DateTime LastEnterTime { get; set; }
        public string Enters { get; set; }
    }
}
