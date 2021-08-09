using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectServer.Models;
using Microsoft.AspNetCore.SignalR;

namespace FinalProjectServer.Hubs
{
    public class NotificationAdapter : INotificationService<AirportImage>
    {
        private readonly IHubContext<AirportNotifications, INotificationClient> _hub; 
        public NotificationAdapter(IHubContext<AirportNotifications, INotificationClient> hub) => _hub = hub;

        public Task Notify(AirportImage args) => _hub.Clients.All.ReceiveAirportImage(args);

        public Task NotifyHistory(List<FlightModel> history) => _hub.Clients.All.ShowHistory(history.ToList());
    }
}
