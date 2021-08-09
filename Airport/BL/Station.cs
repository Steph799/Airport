using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.BL
{
    public class Station
    {
        public int StationId { get; set; }
        public bool IsFree { get; set; }  //true=free false=occupied
        public TimeSpan MaxoccupyTime { get; set; }
       // public int NextStationID { get; set; }

    }
}
