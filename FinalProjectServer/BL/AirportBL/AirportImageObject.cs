﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectServer.Models;

namespace FinalProjectServer.BL.AirportBL
{
    public class AirportImageObject:AirportImage
    {
        public AirportImageObject(List<ProcessStatusModel> processes, bool departurePriority)
        {
            Processes = processes;
            DeparturePriority = departurePriority;
            DateTime date = DateTime.Now;
            ImageTime = new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second);
        }
    }
}
