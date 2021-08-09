using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectServer.Models;

namespace FinalProjectServer.Hubs
{
    public interface INotificationService<T>
    {
        Task Notify(T args); //is the notify suitable for everything
     
        Task NotifyHistory(List<FlightModel> history);
    }
}
