using System;
using System.Collections.Generic;
using System.Text;
using FinalProjectServer.Models;

namespace ProcessLogic
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
            throw new NotImplementedException();
        }
    }
}
