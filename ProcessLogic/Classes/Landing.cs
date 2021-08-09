using System;
using FinalProjectServer.Models;

namespace ProcessLogic
{
    public class Landing : ILanding
    {
        Flight flight;

        public Landing()
        {
            flight = new Flight() { FightCategory = true };
        }

        public void ToDoList()
        {
            throw new NotImplementedException();
        }
    }
}
