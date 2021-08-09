using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectServer.BL.AirportBL;
using FinalProjectServer.BL.StationBL;

namespace FinalProjectServer.Models
{
    public class StationModel
    {
        [Key]
        public int StationId { get; set; }
        public StationType Type { get; set; }
        public bool IsFree { get; set; }  
    }
}
