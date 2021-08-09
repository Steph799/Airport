using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.BL.Processes;
using Airport.Interfaces;

namespace Plane.BL
{
    public interface IAirplane
    {
        void CommunicateWithCT();
        void CheckFunctionality(); //check the plan befre taking off (engin, wings) 
        void ToggleEngineState(); //if is turning on-turn off and the oposite
        void LandingProcess();
        void TakingOffProcess();
        void ManageWheels(bool status); //sub func of process
        void ManageWings(); //sub func of process
        void Load(); //sub func of taking off
        void AlertEmergency(string details); //case of fire
        void MoveToNextStation(); //an airplan know where it is (its station).  
        void FillTheTank();
        bool LogProblem(string problemDetails);
        void Drive();
        void Clean();
    }
}
