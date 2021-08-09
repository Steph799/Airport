using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectServer.BL.AirportBL;

namespace FinalProjectServer.Models
{
    public class AirportImage
    {
        [Key]
        public int ImageId { get; set; }      
        public List<ProcessStatusModel> Processes { get; set; }
        public DateTime ImageTime { get; set; }
        public bool DeparturePriority { get; set; }       
    }
}
