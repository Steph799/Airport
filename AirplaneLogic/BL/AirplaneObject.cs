using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Airport.Interfaces;

namespace Plane.BL
{
    public class AirplaneObject : Airplane, IAirplane
    {     
        public void AlertEmergency(string details) =>
            Console.WriteLine($"Airplane {AirplaneId} alert emergency: {details}");


        public void CheckFunctionality() //part of process (station 1,2 or station 6,7)
        {
            if (IsTankFull) //check before take off (on the ground) sttion 6 or 7
            {
                CommunicateWithCT();
                ManageWheels(true);
                ManageWings();
                ToggleEngineState(); //turn on
                ToggleEngineState(); //turn off
                return;
            }

            //check before landing (1,2)
            if(StationId==1) CommunicateWithCT(); //normal check
            else
            {
                ManageWheels(false);
                ManageWings();
            }                        
        }

        // Load(new TakingOff());
        //   if (Stations[7].IsFree) MoveToNextStation();

        public void Clean() => Console.WriteLine("Cleaning the plane...");

        public void CommunicateWithCT() => Console.WriteLine($"Airplane {AirplaneId} to control tower, do you copy?");


        private void LandingCommunicate()
        {
            string header = $"Airplane {AirplaneId} is";

            switch (StationId)
            {
                case 1:
                    Console.WriteLine($"{header} asking for permition to land");
                    break;
                case 2:
                    Console.WriteLine($"{header} starting the land process");
                    break;
                case 3:
                    Console.WriteLine($"{header} arriving to the airport and is ready to land");
                    break;
                case 4:
                    Console.WriteLine($"{header} landing");
                    break;
                case 5:
                    Console.WriteLine($"{header} going to the terminal");
                    break;
                default: //6,7
                    Console.WriteLine($"{header} parking");
                    break;
            }
        }

        private void TakingOffCommunicate()
        {
            string header = $"Airplane {AirplaneId} is";

            switch (StationId)
            {
                case 4:
                    Console.WriteLine($"{header} taking off");
                    break;
                case 6:
                case 7:
                    Console.WriteLine($"{header} asking for permition to take off");
                    break;
                default:     //8    
                    Console.WriteLine($"{header} going to the runway");
                    break;
            }
        }

        public void Drive() => Console.WriteLine($"Airplane {AirplaneId} is driving");


        public void FillTheTank()
        {
            IsTankFull = true;
            Console.WriteLine("Tank is full");
        }

        public void LandingProcess()
        {
            if (StationId <= 2) CheckFunctionality();
            LandingCommunicate();
            //wait for control tower response...        
        }

        public void Load() => //should I ask which process?
            Console.WriteLine($"{(IsTankFull ? "load" : "unload ")} cargo");

        public bool LogProblem(string problemDetails)
        {
            throw new NotImplementedException();
        }

        public void ManageWheels(bool status) => Console.WriteLine($"{(status ? "Check" : "Take out")} wheels");

        public void ManageWings() => Console.WriteLine("Check wings");


        public void MoveToNextStation()
        {
            if (IsTankFull) ProceedTakingOff();
            else ProceedLanding();
        }

        private void ProceedLanding()
        {
            switch (StationId)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    StationId++;
                    break;
                case 5:
                    if (Stations[5].IsFree) StationId++;
                    else if (Stations[6].IsFree) StationId = 7;
                    break;
                default: //6,7
                    ToggleEngineState();
                    FillTheTank();
                    break;
            }
        }

        private void ProceedTakingOff()
        {
            switch (StationId)
            {
                case 4: //remove airplane
                        // airplane = null (only control tower remove the plane)

                    break;
                case 6:
                case 7:
                    StationId = 8;
                    break;
                default: //8
                    StationId = 4;
                    break;
            }
        }

        public void TakingOffProcess()
        {
            if (StationId == 6 || StationId == 7) CheckFunctionality();
            TakingOffCommunicate();
        }

        public void ToggleEngineState()
        {
            string status = "is turned";
            EngineState = !EngineState;
            Console.WriteLine($"{(EngineState ? $"{status} on" : $"{status} off")}");
        }     
    }
}
