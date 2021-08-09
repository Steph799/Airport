using System;
using System.Collections.Generic;
using System.Text;
using FinalProjectServer.Models;

namespace Airport.BL.Processes
{
    class TakingOff : ITakingOff
    {
        Flight flight;

        public TakingOff()
        {
            flight = new Flight() { FightCategory =false};
        }

        public void ToDoList()
        {
            //pass station 6 (or 7)-->8-->4 once your in the station, the task is completed. when
        }
    }
}
