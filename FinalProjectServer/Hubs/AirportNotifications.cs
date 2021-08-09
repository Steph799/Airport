using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectServer.BL.AirportBL;
using Microsoft.AspNetCore.SignalR;

namespace FinalProjectServer.Hubs
{
    public class AirportNotifications:Hub<INotificationClient>
    {
        IAirport _airport;
        public AirportNotifications(IAirport airport) => _airport = airport;    
    }
}
