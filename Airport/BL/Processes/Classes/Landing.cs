using System;
using FinalProjectServer.Models;

namespace Airport.BL.Processes
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
            //pass station 1-6 (or 7). once your in the station, the task is completed
        }
    }
}
